function solve(speed, area) {

    let speedLimit = 0;
    switch (area) {
        case "motorway": speedLimit = 130; break;
        case "interstate": speedLimit = 90; break;
        case "city": speedLimit = 50; break;
        case "residential": speedLimit = 20; break;
    }

    let isWithinLimit = true;
    let difference = 0;
    let status;

    if (speed > speedLimit) {
        isWithinLimit = false;
        difference = speed - speedLimit;

        if (difference <= 20) {
            status = "speeding";
        } else if (difference <= 40) {
            status = "excessive speeding";
        } else {
            status = "reckless driving";
        }
    }

    if (isWithinLimit === true) {
        return `Driving ${speed} km/h in a ${speedLimit} zone`;
    } else {
        return `The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - ${status}`;
    }


}

console.log(solve(40, 'city'))
console.log(solve(21, 'residential'))
console.log(solve(120, 'interstate'))
console.log(solve(200, 'motorway'))