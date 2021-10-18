function show(name) {
    chart_draw();
    $('#chart_qt').hide();
    $('#chart_exam').hide();
    $('#chart_final').hide();
    if (name != '') $(`#${name}`).show();
}
var value = { value: '', type: '', subject: '', semester: '', course: '', period: '' };
var chart_data = {
    qt: [],
    exam: [],
    final: []
};
$(document).ready(function () {
    var table = $("#table_id").DataTable({
        "processing": true,
    });

    $('form').submit(function (event) {
        $.ajax({
            method: $(this).attr('method'),
            url: $(this).attr('action'),
            data: $(this).serialize(),
            type: 'GET',
            // other AJAX settings goes here
            // ..
            error: function (xhr, ajaxOptions, thrownError) {
                console.log(xhr);
                console.log(ajaxOptions);
                console.log(thrownError);
            }
        }).done(function (response) {
            if (response != null) {
                if (response.code == 500) {
                    alert("Không có dữ liệu được nhận!")
                }
                else {
                    if (response.data != null) {
                        let temp = $("#gr")
                        temp.empty();
                        temp.append('<option value="">Chọn nhóm môn học---</option>');
                        for (let i = 0; i < response.data.length; i++) {
                            let k = '<option value=' + response.data[i].id + '>' + response.data[i].display_name + '</option>';
                            temp.append(k)
                        }
                        let temp1 = $("#gr1")
                        temp1.empty();
                        temp1.append('<option value="">Chọn lớp quản lý---</option>');
                        for (let i = 0; i < response.data1.length; i++) {
                            let k = '<option value=' + response.data1[i].id + '>' + response.data1[i].className + '</option>';
                            temp1.append(k)
                        }
                    } else alert("Không có nhóm phù hợp!");
                }
            }
            else {
                alert("Đã có lỗi xảy ra!");
            }
            // Process the response here
        });
        event.preventDefault(); // <- avoid reloading
    });
})
function change(res) {
    show('');
    value.value = res.value;
    value.type = res.id;
    $("#_loading").show();
    $("#main_content").hide();

    $.ajax({
        url: '/Semester/GetMark',
        dataType: "json",
        type: 'POST',
        data: { id: value.value, type: value.type, subject: value.subject, semester: value.semester },
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr);
            console.log(ajaxOptions);
        }
    }).done(function (response) {
        if (response.data != null) {
            if (response.code == 200) {
                let data1 = response.data.map(Object.values);
                chart_data = response.chart_mark;
                $("#table_id").DataTable().clear();
                $("#table_id").DataTable().rows.add(data1);
                $("#table_id").DataTable().draw();
                $("#_loading").hide();
                $("#main_content").show()
            }
            else {
                alert(response.data);
            }
        }
        else {
            alert("Kết nối thất bại!")
        }
    });
    event.preventDefault(); // <- avoid reloading
}

function setSemester(res) {
    value.semester = res.value;
    setFillter();
}
function setSubject(res) {
    value.subject = res.value;
}
function setCourse(res) {
    value.course = res.value;
    setFillter();
}
function setPeriod(res) {
    value.period = res.value;
    setFillter();
}

function setFillter() {
    $.ajax({
        url: '/Semester/getSubject',
        dataType: "json",
        type: 'POST',
        data: { courseId: value.course, semesterId:value.semester, periodId:value.period },
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr);
            console.log(ajaxOptions);
        }
    }).done(function (response) {
        if (response.data != null) {
            if (response.code == 200) {
                response.data = response.data.sort((a,b) => { return (a.subject_name >= b.subject_name?1:-1)});
                let temp = $("#monHoc")
                temp.empty();
                temp.append('<option value="">Môn học</option>');
                for (let i = 0; i < response.data.length; i++) {
                    let k = '<option value=' + response.data[i].id + '>' + response.data[i].subject_name + '</option>';
                    temp.append(k)
                }
            }
            else {
                alert(response.data);
            }
        }
        else {
            alert("Kết nối thất bại!")
        }
    });
    event.preventDefault(); // <- avoid reloading
}

function xuat1() {
    data = value.value;
    let s = '/Semester/Export?file=' + value.type + "z" + value.subject + "z" + value.semester + "z" + value.course + "z" + value.period + "z" + data;
    window.location = s;
}
function xuat() {
    data = value.value;
    let s = '/Semester/ExportAll?file=' + value.type + "z" + value.subject + "z" + value.semester + "z" + value.course + "z" + value.period + "z" + data;
    window.location = s;
}
function chart_draw() {
    massPopChart1.config.data.datasets[0].data = chart_data.exam;
    massPopChart1.update();
    massPopChart2.config.data.datasets[0].data = chart_data.final;
    massPopChart2.update();
    massPopChart.config.data.datasets[0].data = chart_data.qt;
    massPopChart.update();
}

var mychart1 = document.getElementById('myChart1').getContext('2d');
var myChart = document.getElementById('myChart').getContext('2d');
var myChart2 = document.getElementById('myChart2').getContext('2d');

var dataLabel = ['F', 'D', 'C', 'B', 'A'];

var massPopChart1 = new Chart(myChart1, setChart('Biểu đồ phân bố điểm thi', chart_data.exam, 'Điểm thi'));
var massPopChart = new Chart(myChart, setChart('Biểu đồ phân bố điểm quá trình', chart_data.qt, 'Điểm quá trình'));
var massPopChart2 = new Chart(myChart2, setChart('Biểu đồ phân bố điểm tổng kết', chart_data.final, 'Điểm tổng kết'));

function setChart(title, data, label) {
    return {
        type: 'bar', // bar, horizontalBar, pie, line, doughnut, radar, polarArea
        data: {
            labels: dataLabel,
            datasets: [{
                label: label,
                data: data,
                //backgroundColor:'green',
                backgroundColor: '#198002',
                borderColor: '#7C7AFD',
                hoverBorderWidth: 1,
                hoverBorderColor: '#7C7AFD'
            }]
        },
        options: {
            title: {
                display: true,
                text: title,
                fontSize: 20
            },
            legend: {
                display: true,
                position: 'right',
                labels: {
                    fontColor: '#000'
                }
            },
            layout: {
                padding: {
                    left: 50,
                    right: 0,
                    bottom: 0,
                    top: 0
                }
            },
            tooltips: {
                enabled: true
            }
        }
    }
}