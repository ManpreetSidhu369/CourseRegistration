function openModel(CourseId) {
    let selector = ".course-students-model-" + CourseId;
    $(selector).show();
}

function closeModel(CourseId) {
    let selector = ".course-students-model-" + CourseId;
    $(selector).hide();

}
