function roadRadar(arg1) {
    let currentSpeed = Number(arg1[0]);
    let currentArea = arg1[1];
    let speeding = 20;
    let excessiveSpeeding = 40;
    let motorwayS = 130;
    let interstateS = 90;
    let cityS = 50;
    let residentialS = 20;

    switch (currentArea) {
        case "motorway":
            if (currentSpeed > motorwayS && currentSpeed <= motorwayS + speeding) {
                console.log(`speeding`);
            }
            else if (currentSpeed > motorwayS + speeding && currentSpeed <= motorwayS + excessiveSpeeding) {
                console.log(`excessive speeding`)
            }
            else if (currentSpeed > motorwayS + excessiveSpeeding) {
                console.log(`reckless driving`)
            }
            break;
        case "interstate":
            if (currentSpeed > interstateS && currentSpeed <= interstateS + speeding) {
                console.log(`speeding`);
            }
            else if (currentSpeed > interstateS + speeding && currentSpeed <= interstateS + excessiveSpeeding) {
                console.log(`excessive speeding`)
            }
            else if (currentSpeed > interstateS + excessiveSpeeding) {
                console.log(`reckless driving`)
            }
            break;
        case "city":
            if (currentSpeed > cityS && currentSpeed <= cityS + speeding) {
                console.log(`speeding`);
            }
            else if (currentSpeed > cityS + speeding && currentSpeed <= cityS + excessiveSpeeding) {
                console.log(`excessive speeding`)
            }
            else if (currentSpeed > cityS + excessiveSpeeding) {
                console.log(`reckless driving`)
            }
            break;
        case "residential":
            if (currentSpeed > residentialS && currentSpeed <= residentialS + speeding) {
                console.log(`speeding`);
            }
            else if (currentSpeed > residentialS + speeding && currentSpeed <= residentialS + excessiveSpeeding) {
                console.log(`excessive speeding`)
            }
            else if (currentSpeed > residentialS + excessiveSpeeding) {
                console.log(`reckless driving`)
            }
            break;
    }
}