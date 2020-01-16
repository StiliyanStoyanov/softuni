function totalBitcoinsPurchased(stringArr) {
    let goldPrice = 67.51;
    let bitcoinPrice = 11949.16;

    let goldPerDay = stringArr.map(Number);
    console.log(goldPerDay);
    let totalMoney = 0;
    let bitcoins = 0;
    let firstBitcoinDay = 0;
    for (let i = 0; i < goldPerDay.length; i++) {
        let goldGram = goldPerDay[i];
        if ((i + 1) % 3 === 0) {
            goldGram *= 0.7
        }
        totalMoney += goldGram * goldPrice;
        while (totalMoney > bitcoinPrice) {
            bitcoins++;
            totalMoney -= bitcoinPrice;
        }
        if (bitcoins > 0 && firstBitcoinDay === 0) {
            firstBitcoinDay = i + 1;
        }
    }
    console.log(`Bought bitcoins: ${bitcoins}`);
    if (firstBitcoinDay >= 1) {
        console.log(`Day of the first purchased bitcoin: ${firstBitcoinDay}`);
    }
    console.log(`Left money: ${totalMoney.toFixed(2)} lv.`);
}

totalBitcoinsPurchased(['3124.15', '504.212', '2511.124']);