function timeToWalk(numberOfSteps, lengthInMeters, speedInKmPerH) {

    let distance = numberOfSteps * lengthInMeters;
    let speedInSeconds = speedInKmPerH / 3.6;
    let additionalMinutes = Math.floor(distance / 500) * 60;
    let time = Math.round(distance / speedInSeconds + additionalMinutes);

    var date = new Date(null);
    date.setSeconds(time);
    var timeString = date.toISOString().substr(11, 8);
    console.log(timeString)
}