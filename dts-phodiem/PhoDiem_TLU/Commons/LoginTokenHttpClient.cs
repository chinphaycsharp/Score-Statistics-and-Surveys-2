using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PhoDiem_TLU.Commons;
using PhoDiem_TLU.Models;
using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PhoDiem_TLU.Core
{
    public class LoginTokenHttpClient
    {
        //url đăng nhập
        private static readonly string url = "http://sv313.tlu.edu.vn:8080/education/oauth/token";
        //url lấy user ứng với token
        private static readonly string urlGet = "http://sv313.tlu.edu.vn:8080/education/api/users/getCurrentUser";
        private static readonly string urlGetRole = "http://sv313.tlu.edu.vn:8080/education/api/roles/all";
        private static readonly string urlAddUser = "http://sv313.tlu.edu.vn:8080/education/api/users";
        private static readonly string urlGetListUser = "http://sv313.tlu.edu.vn:8080/education/api/users/";
        private static readonly string urlDeleteUser = "http://sv313.tlu.edu.vn:8080/education/api/user/ext/remove";

        public static TokenResult _token = null;
        
        public static async Task<TokenResult> LoginDTSAsync(UserLoginViewModel model)
        {
            //Dùng HTTPClient để giao tiếp với server
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //Tạo model chứa thông tin login
            var user = new UserLoginViewModel()
            {
                client_id = "education_client",
                grant_type = "password",
                username = model.username.ToString(),
                password = model.password.ToString(),
                client_secret = "password"
            };

            //Convert ra json
            string json = await Task.Run(() => JsonConvert.SerializeObject(user));
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //Send request lên server
            HttpResponseMessage message = await client.PostAsync(string.Format(url), httpContent);
            //Nếu IsSuccessStatusCode = 200 thì sẽ trả ra token, sau đó lấy token gán vào session
            if (message.IsSuccessStatusCode)
            {
                var responseData = message.Content.ReadAsStringAsync().Result;
                string barearToken = responseData;
                string[] result = barearToken.Split(',');
                _token = TokenResult.handleStringToToken(result);
                return _token;
            }
            return null;
        }

        public static bool GetCurrentUser(TokenResult tokenResult)
        {
            //Tương tự như hàm trên sử dụng httpclient để giao tiếp với server
            if(tokenResult != null)
            {
                using (var client = new HttpClient())
                {
                    //Gán header để Authorization với Bearer Token
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            tokenResult.access_token);

                    var result = client.GetAsync(urlGet).Result.Content.ReadAsStringAsync();

                    if (result != null)
                    {
                        bool check = handleRoles(result.Result);
                        return check;
                    }
                }
            }
            return false;
        }

        public static UserLogin GetUser(TokenResult tokenResult)
        {
            //Tương tự như hàm trên sử dụng httpclient để giao tiếp với server
            if (tokenResult != null)
            {
                using (var client = new HttpClient())
                {
                    //Gán header để Authorization với Bearer Token
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            tokenResult.access_token);

                    var result = client.GetAsync(urlGet).Result.Content.ReadAsStringAsync();
                    var myObject = JValue.Parse(result.Result);
                    var jToken = (JToken)myObject;
                    var roles = jToken["roles"];
                    UserLogin user = new UserLogin();
                    List<RoleViewModel> resultRoles = RoleViewModel.getRoles(roles);
                    user.roles = resultRoles;
                    return user;
                }
            }
            return new UserLogin();
        }

        private static bool handleRoles(string jsoninput)
        {
            JObject json = JObject.Parse(jsoninput);
            var jsonResult = json.Root;
            var roles = jsonResult["roles"];
            if (roles != null)
            {
                List<RoleViewModel> resultRoles = RoleViewModel.getRoles(roles);
                foreach(RoleViewModel item in resultRoles)
                {
                    if(item.name == Constants.ROLE_EXAM_MANAGERMENT)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
       
        public static IEnumerable<RoleViewModel> getAllRoles(TokenResult tokenResult)
        {
            if(tokenResult != null)
            {
                using (var client = new HttpClient())
                {
                    //Gán header để Authorization với Bearer Token
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            tokenResult.access_token);

                    var result = client.GetAsync(urlGetRole).Result.Content.ReadAsStringAsync();
                    var myObject = JValue.Parse(result.Result);
                    var roles = (JToken)myObject;
                    List<RoleViewModel> resultRoles = RoleViewModel.getRoles(roles);
                    if (resultRoles.Count > 0)
                    {
                        return resultRoles.AsEnumerable();
                    }
                }
            }
            return null;
        }

        public static async Task<bool> AddUserAsync(UserAddViewModel model, TokenResult tokenResult)
        {
            if (tokenResult != null)
            {
                using (var client = new HttpClient())
                {
                    //Gán header để Authorization với Bearer Token
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            tokenResult.access_token);
                    string json = JsonConvert.SerializeObject(model);

                    //var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                    //var byteContent = new ByteArrayContent(buffer);
                    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");


                    var result = client.PostAsync(urlAddUser, stringContent).Result;

                    return result.IsSuccessStatusCode;
                }
            }
            return await Task.FromResult(false);
        }

        public static async Task<bool> UpdateUserAsync(UpdateUserViewModel model, TokenResult tokenResult)
        {
            if (tokenResult != null)
            {
                using (var client = new HttpClient())
                {
                    //Gán header để Authorization với Bearer Token
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            tokenResult.access_token);
                    string json = JsonConvert.SerializeObject(model);

                    //var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                    //var byteContent = new ByteArrayContent(buffer);
                    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");


                    var result = client.PostAsync(urlAddUser, stringContent).Result;

                    return result.IsSuccessStatusCode;
                }
            }
            return await Task.FromResult(false);
        }

        public static DataViewModels GetListUser(TokenResult tokenResult,int? page, int pageSize)
        {
            UserLogin user = LoginTokenHttpClient.GetUser(tokenResult);
            bool isAdmin = false;
            foreach (var item in user.roles)
            {
                if(item.name == Constants.ROLE_ADMIN)
                {
                    isAdmin = true;
                    break;
                }
            }
            if(isAdmin)
            {
                if (tokenResult != null)
                {
                    using (var client = new HttpClient())
                    {
                        //Gán header để Authorization với Bearer Token
                        client.DefaultRequestHeaders.Add("Accept", "application/json");
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                                tokenResult.access_token);

                        var result = client.GetAsync(urlGetListUser + page.ToString() + "/" + pageSize.ToString()).Result.Content.ReadAsStringAsync();
                        var myObject = JValue.Parse(result.Result);
                        var jToken = (JToken)myObject;
                        //List<UserViewModel> users = new List<UserViewModel>();
                        if (jToken["content"] != null)
                        {
                            DataViewModels pagination = new DataViewModels();
                            var content = jToken["content"];
                            pagination.content = UserViewModel.HandleJtokenToUserResult(content);

                            pagination.size = (int)jToken["size"];
                            pagination.numberOfElements = (int)jToken["numberOfElements"];
                            pagination.totalElements = (int)jToken["totalElements"];
                            pagination.totalPages = (int)jToken["totalPages"];
                            return pagination;
                        }
                    }
                }
            }
            else
            {
                return null;
            }
            return null;
        }

        public static bool DeleteUsers(TokenResult tokenResult, int[] selectedUsers)
        {
            if(tokenResult != null)
            {
                using (var client = new HttpClient())
                {
                    //Gán header để Authorization với Bearer Token
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(urlDeleteUser),
                        Content = new StringContent(JsonConvert.SerializeObject(selectedUsers), Encoding.UTF8, "application/json")

                    };
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenResult.access_token);

                    var result = client.SendAsync(request).Result;

                    return result.IsSuccessStatusCode;
                }
            }
            return false;
        }

        public static UserViewModel  DetailUser(TokenResult tokenResult, int id)
        {
           if(tokenResult != null)
            {
                using (var client = new HttpClient())
                {
                    //Gán header để Authorization với Bearer Token
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            tokenResult.access_token);

                    var result = client.GetAsync(urlGetListUser + id.ToString()).Result.Content.ReadAsStringAsync();
                    var myObject = JValue.Parse(result.Result);
                    var user = (JToken)myObject;
                    if (user.HasValues)
                    {
                        UserViewModel userDetail = UserViewModel.getUser(user);
                        return userDetail;
                    }
                }
            }
            return new UserViewModel();
        }

        public static List<RoleViewModel> getRolesByIdUser(TokenResult tokenResult, int id)
        {
            if(tokenResult != null)
            {
                using (var client = new HttpClient())
                {
                    //Gán header để Authorization với Bearer Token
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            tokenResult.access_token);

                    var result = client.GetAsync(urlGetListUser + id.ToString()).Result.Content.ReadAsStringAsync();
                    var myObject = JValue.Parse(result.Result);
                    var user = (JToken)myObject;
                    var roles = user["roles"];
                    if (roles.HasValues)
                    {
                        List<RoleViewModel> userDetail = RoleViewModel.getRoles(user);
                        return userDetail;
                    }
                }
            }
            return new List<RoleViewModel>();
        }
    }   
}   