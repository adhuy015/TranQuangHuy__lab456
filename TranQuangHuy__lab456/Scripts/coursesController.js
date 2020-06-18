var CoursesController = funtion(){
    var button;
var init = function () {
    $(".js-toggle-attendance").click(toggleAttendance);
};

var toggleAttendance = funtion(e){
    button = $(e.target);
if (button.hasClass(btn-default )) {
    createAttendance();
}

else {
    deleteAttendance();
}
};
var createAttendance = funtion(){
    $.post("/api/attendances", { courseId: button.attr("data-course-id") })
        .done(done)
        .fail(fail);
};
var deleteAttendance = funtion(){
    $.ajax({
        url: "/api/attendances" + button.attr("data-course-id"),
        method:"DELETE"
})
        .done(done)
        .fail(fail);
};
var done = funtion(){
    var text = (button.text() == "Going") ? "Going?" : "Going";
button.toggleClass("btn-info").toggleClass("btn-default").text(text);
};
var fail = funtion(){
    alert("something failed");
};
return {
    init:init
}
}();