var table;

function initTableData() {
    table = $('#table-course-subject').DataTable({
        "processing": true,
    });
}

var value = { subject: '', semester: '', course: '', period: '' };

$(document).ready(function () {
    initTableData();
    var ok = false;
    let dataMark = null;
    handlefilter();

    $('#list-header').on({
        mouseenter: function () {
            $(this).css("background-color", "lightgray");
        },
        mouseleave: function () {
            $(this).css("background-color", "lightblue");
        },
    });
});

function handlefilter() {
    var butt = document.getElementById('btn-submit');
    butt.addEventListener('click', function (event) {
    });
    $('form').submit(function (even) {
        if (even.originalEvent.submitter.value == 'Lọc') {
            $.ajax({
                method: $(this).attr('method'),
                url: $(this).attr('action'),
                data: $(this).serialize(),
                datatype: 'json',
                type: 'GET',
                // other AJAX settings goes here
                // ..

                error: function (xhr, ajaxOptions, thrownError) {
                    console.log(xhr);
                    console.log(ajaxOptions);
                    console.log(thrownError);
                }
            }).done(function (response) {
                if (response.data != null) {
                    if (response.code == 200) {
                        dataMark = response.data;
                        fillDataToChart(response.data, response.type);
                        // fillDataToChartPie(response.sumMark);
                        ok = true;
                        showHandler(response.type);

                        console.log(response.data)
                    }
                    else {
                        console.log(reponse.sublist);
                    }
                }
                else {
                    console.log("Kết nối thất bại!");
                    alert('Không có dữ liệu');
                }
            });
            event.preventDefault(); // <- avoid reloading
        }
    })
}
function showHandler(val) {
    console.log(val);
    if (dataMark != null) {
        let data = dataMark.map(Object.values);
        if (val === "HTN") {
            $("#table-course-subject").DataTable().clear();
            $("#table-course-subject").DataTable().rows.add(data);
            $("#table-course-subject").DataTable().draw();
            $("#table-course-subject").show();
            $("#table-by-teacher_wrapper").hide();
            $("#table-by-enrollmentClass_wrapper").hide();
        }
        else if (val === "HTGV") {
            $("#table-by-teacher").DataTable().clear();
            $("#table-by-teacher").DataTable().rows.add(data);
            $("#table-by-teacher").DataTable().draw();
            $("#table-by-teacher").show();
            $("#table-course-subject_wrapper").hide();
            $("#table-by-enrollmentClass_wrapper").hide();
        }
        else {
            $("#table-by-enrollmentClass").DataTable().clear();
            $("#table-by-enrollmentClass").DataTable().rows.add(data);
            $("#table-by-enrollmentClass").DataTable().draw();
            $("#table-by-enrollmentClass").show();
            $("#table-course-subject_wrapper").hide();
            $("#table-by-teacher_wrapper").hide();
        }
    }
}

function fillDataToChart(list, type) {
    let typeChart = 'horizontalBar';
    let istypeBar = false;
    let labels;
    if (type == 'HTN') {
        labels = list.map(function (data) {
            return data.courseSubjectName;
        })
    }
    else if (type == 'HTGV') {
        labels = list.map(function (data) {
            return data.teacherName;
        })
        istypeBar = true;
        typeChart = 'bar';
    }
    else {
        labels = list.map(function (data) {
            return data.enrollmentClassName;
        })
    }
    cleardata('testChart2', istypeBar);
    var chartBar = document.getElementById('testChart2').getContext('2d');
    const chartMark = {
        type: typeChart,
        data: {
            labels: labels,
            datasets: [
                {
                    label: "Điểm A",
                    data: list.map(function (mark) {
                        return mark.A;
                    }),
                    backgroundColor: '#333',
                },
                {
                    label: "Điểm B",
                    data: list.map(function (mark) {
                        return mark.B;
                    }),
                    backgroundColor: '#7FBA00'
                },
                {
                    label: "Điểm C",
                    data: list.map(function (mark) {
                        return mark.C;
                    }),
                    backgroundColor: '#DD5246'
                },
                {
                    label: "Điểm D",
                    data: list.map(function (mark) {
                        return mark.D;
                    }),
                    backgroundColor: '#4B8BF4'
                },
                {
                    label: "Điểm F",
                    data: list.map(function (mark) {
                        return mark.F;
                    }),
                    backgroundColor: '#FFCD42'
                }

            ]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'top',
                },
                title: {
                    display: true,
                    text: 'Biểu đồ điểm A,B,C,D'
                }
            }
        },
    }
    var chart = new Chart(chartBar, chartMark);
    chart.update();
}
function showChart2() {
    if (ok) {
        $('#${testChart2}').show();
    }
}
function showChart(name, nameSwap) {
    if (ok) {
        $(`#${nameSwap}`).show();
        $(`#${name}`).hide();
    }
}
function xuat() {
    form.action = 'ExportExcelDataCourseSubject2'
}
function cleardata(name, istypeBar) {
    var element = document.getElementById(name);
    var parentElement = element.parentElement;
    element.remove();
    if (istypeBar) {
        parentElement.innerHTML = `<canvas id="${name}"  width="1000"></canvas>`;
    }
    else {
        parentElement.innerHTML = `<canvas id="${name}"  height = "800" ></canvas>`;
    }
}

function setCourse(res) {
    value.course = res.value;
    setFillter();
}
function setSemester(res) {
    value.semester = res.value;
    setFillter();
}
function setPeriod(res) {
    value.period = res.value;
    setFillter();
}
function setSubject(res) {
    value.subject = res.subject;
}


function setFillter() {
    $.ajax({
        url: '/StatisticsByCourseSubject/getSubject',
        dataType: "json",
        type: 'POST',
        data: { courseId: value.course, semesterId: value.semester, periodId: value.period },
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr);
            console.log(ajaxOptions);
        }
    }).done(function (response) {
        if (response.data != null) {
            if (response.code == 200) {
                response.data = response.data.sort((a, b) => { return (a.subject_name >= b.subject_name ? 1 : -1) });
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