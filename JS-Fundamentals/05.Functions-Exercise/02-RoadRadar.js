function getInfraction([speed, zone]) {
    let limit = getLimit();
    function getLimit() {
        switch (zone) {
            case 'motorway': return 130;
            case 'interstate': return 90;
            case 'city': return 50;
            case 'residential': return 20;
        }
    }

    let severity = getInfractionSeverity(speed,limit);
    function getInfractionSeverity(speed, limit) {
        let overSpeed = speed - limit;
        if (overSpeed <= 0) {
            return "";
        }
        else{
            if (overSpeed <= 20) {
                return 'speeding';
            }
            else if (overSpeed > 20 && overSpeed <= 40) {
                return 'excessive speeding';
            }
            else if (overSpeed > 40){
                return 'reckless driving';
            }
        }
    }
    console.log(severity);
}


getInfraction([40, "city"]);