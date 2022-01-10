
// Grade calculator function
$("#gradefinal").click(function () {
    //calculate grade from grade calculator form
    finalGrade = ($('#assign').val() * .55) + ($('#gp').val() * .05) + ($('#qz').val() * .10) + ($('#ex').val() * .20) + ($('#intx').val() * .10)

    //if statement to determine the appropriate letter grade
    finalLetter = ''
    if (finalGrade >= 94) {
        finalLetter = 'A'
    }
    else if (finalGrade >= 90) {
        finalLetter = 'A-'
    }
    else if (finalGrade >= 87) {
        finalLetter = 'B+'
    }
    else if (finalGrade >= 84) {
        finalLetter = 'B'
    }
    else if (finalGrade >= 80) {
        finalLetter = 'B-'
    }
    else if (finalGrade >= 77) {
        finalLetter = 'C+'
    }
    else if (finalGrade >= 74) {
        finalLetter = 'C'
    }
    else if (finalGrade >= 70) {
        finalLetter = 'C-'
    }
    else if (finalGrade >= 67) {
        finalLetter = 'D+'
    }
    else if (finalGrade >= 64) {
        finalLetter = 'D'
    }
    else if (finalGrade >= 60) {
        finalLetter = 'D-'
    }
    else if (finalGrade < 60) {
        finalLetter = 'E'
    }

    //alert the final grade and letter grade
    alert('Your score is ' + finalGrade + ' and your letter grade is ' + finalLetter);
})