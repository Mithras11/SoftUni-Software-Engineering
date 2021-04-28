function solve(input) {
    let result;

    switch (input) {
        case 'Monday': result = 1; break;
        case 'Tuesday': result = 2; break;
        case 'Wednesday': result = 3; break;
        case 'Thursday': result = 4; break;
        case 'Friday': result = 5; break;
        case 'Saturday': result = 6; break;
        case 'Sunday': result = 7; break;
        default: result = 'error'; break;
    }

    console.log(result);
}

//--------different solution------//

function solve(day) {
    let daysMap = {
        "Monday": 1,
        "Tuesday": 2,
        "Wednesday": 3,
        "Thursday": 4,
        "Friday": 5,
        "Saturday": 6,
        "Sunday": 7
    }

    let result = daysMap[day] ? daysMap[day] : 'error';
    console.log(result);
}


solve('Monday')
solve('Friday')
solve(4)