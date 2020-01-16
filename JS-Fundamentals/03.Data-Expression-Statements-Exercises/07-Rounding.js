function roundNumber([numberToRound, roundLength]) {
    if (roundLength > 15){
        roundLength = 15;
    }
    let result = numberToRound.toFixed(roundLength);
    result = parseFloat(result);
    console.log(result);
}

roundNumber([10.5, 3]);