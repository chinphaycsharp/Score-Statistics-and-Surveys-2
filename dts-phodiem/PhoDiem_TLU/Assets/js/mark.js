


$(document).ready(function () {
    var ok = false;
    var dataMark = null;
    handlefilter();
    var table = $("#table_id_course-subject").DataTable({
        "processing": true,
        });
        
})

function handlefilter() {
    var butt = document.getElementById('show__btn-id');
    butt.addEventListener('click', function (event) {

});
$('form').submit(function (even) {
        if (even.originalEvent.submitter.value == 'Hiển thị') {
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
                    fillDataToChartPie(response.sumMark);
                    ok = true;
                    showHandler(response.type);
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
            $("#table_id_course-subject").DataTable().clear();
            $("#table_id_course-subject").DataTable().rows.add(data);
            $("#table_id_course-subject").DataTable().draw();
            $("#table_id_course-subject").show();
            $("#table_id_teacher_wrapper").hide();
            $("#table_id_enrollmentClass_wrapper").hide();
        }
        else if (val === "HTGV") {
            $("#table_id_teacher").DataTable().clear();
            $("#table_id_teacher").DataTable().rows.add(data);
            $("#table_id_teacher").DataTable().draw();
            $("#table_id_teacher").show();
            $("#table_id_course-subject_wrapper").hide();
            $("#table_id_enrollmentClass_wrapper").hide();
        }
        else {
            $("#table_id_enrollmentClass").DataTable().clear();
            $("#table_id_enrollmentClass").DataTable().rows.add(data);
            $("#table_id_enrollmentClass").DataTable().draw();
            $("#table_id_teacher_wrapper").hide();
            $("#table_id_course-subject_wrapper").hide();
            $("#table_id_enrollmentClass").show();
        }

    }
}
function fillDataToChart(list,type) {
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
    cleardata('myChart', istypeBar);
    var chartBar = document.getElementById('myChart').getContext('2d');
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
    legend: {
        display: true
                },
    title: {
        display: true,
    text: 'Tỉ lệ điểm A,B,C,D',
    fontSize:20
                    
                },
                
               
            },
        }
    var chart = new Chart(chartBar, chartMark);
    chart.update();
}
function fillDataToChartPie(list) {
    cleardata('chartPie', true);
    var chartPie = document.getElementById('chartPie').getContext('2d');
    let title = 'Tỉ lệ điểm A,B,C,D';
    var labels = ["Điểm A", "Điểm B", "Điểm C", "Điểm D", "Điểm F"];

    var barColors = [
    "#b91d47",
    "#00aba9",
    "#2b5797",
    "#e8c3b9",
    "#1e7145"
    ];

    var chart = new Chart('chartPie', {
        type: 'pie',
    data: {
        labels: labels,
    datasets: [
    {
        data: list,
    backgroundColor: barColors,
                    },


    ]

            },
    options: {
        title: {
        display: true,
    text: title,
    fontSize: 20
                },
    legend: {
        display: true,
                }
            }
        });
    chart.update();
}
function showChart(name, nameSwap) {
    if (ok) {
        $(`#${nameSwap}`).show();
        $(`#${name}`).hide();
    }
}
function cleardata(name,istypeBar) {
    var element = document.getElementById(name);
    var parentElement = element.parentElement;
    element.remove();
    if (istypeBar) {
        parentElement.innerHTML = `<canvas id="${name}" width="1000"></canvas>`;
        }
    else {
        parentElement.innerHTML = `<canvas id="${name}" height="800"></canvas>`;
    }
        
}
