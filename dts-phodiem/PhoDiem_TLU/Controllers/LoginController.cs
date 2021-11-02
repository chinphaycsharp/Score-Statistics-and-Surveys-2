
using PhoDiem_TLU.Commons;
using PhoDiem_TLU.Core;
using PhoDiem_TLU.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PhoDiem_TLU.Controllers
{
    public class LoginController : Controller
    {
        public TokenResult token = new TokenResult();
        #region
        // post: Login
        //[HttpPost]
        //[Route("Index")]
        //public async System.Threading.Tasks.Task<JsonResult> Index()
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(url);
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //    var user = new UserLoginViewModel()
        //    {
        //        client_id = "education_client",
        //        grant_type = "password",
        //        username = "lequang",
        //        password = "123456",
        //        client_secret = "password"
        //    };

        //    string json = await Task.Run(() => JsonConvert.SerializeObject(user));
        //    var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

        //    httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        //    HttpResponseMessage message = await client.PostAsync(String.Format(url), httpContent);
        //    if (message.IsSuccessStatusCode)
        //    {
        //        var responseData =   message.Content.ReadAsStringAsync().Result;
        //        string barearToken = responseData;
        //        string[] result = barearToken.Split(',');
        //        TokenResult token = TokenResult.handleStringToToken(result);
        //        Session.Add(SeesionSystems.USER_TOKEN, token);
        //        if(Session[SeesionSystems.USER_TOKEN] != null)
        //        {

        //        }
        //        //var jsonResponse = JsonConvert.DeserializeObject<List<string>>(responseData);
        //        return Json(token);
        //    }
        //    return Json(message);

        //}

        #endregion

        //Tạo view Login
        public ActionResult Index()
        {
            return View();
        }

        //Action để login lên sv313
        [HttpPost]
        [Route("Index")]
        public async System.Threading.Tasks.Task<ActionResult> Login(UserLoginViewModel model)
        {
            //Tạo token
            var _token = await LoginTokenHttpClient.LoginDTSAsync(model);

            //Nếu đăng nhập thành công sẽ gán token
            if (_token !=null)
            {
                token = _token;
                Session.Add(SeesionSystems.USER_TOKEN, token);
                //Sau khi đăng nhập lấy thông tin user với token đã tạo
                bool c = LoginTokenHttpClient.GetCurrentUser(token);
                
                //Kiểm tra nếu user có quyền P4 thì cho vào
                if(c)
                {
                    Session.Add(Constants.ROLE_EXAM_MANAGERMENT, Constants.ROLE_EXAM_MANAGERMENT);
                    return RedirectToAction("ListUser", "User");
                }
            }
            return View("Error");

        }

        public ActionResult Error()
        {
            return View("Login", "Error");
        }

        //Hàm logut và xóa session
        public ActionResult Logout()
        {
            Session[SeesionSystems.USER_TOKEN] = null;
            Session[Constants.ROLE_EXAM_MANAGERMENT] = null;

            return RedirectToAction("Index","Login");
        }

    }
}