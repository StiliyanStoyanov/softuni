function travelData(input) {
    let data = new Map();
    for (const dataElement of input) {
        let current = dataElement.split(' > ').filter(x => x !== '');
        let country = current[0];
        let city = current[1];
        let price = Number(current[2]);
        if (!data.has(country)) {
            data.set(country, new Map().set(city, price));
        }
        else {
            if (!data.get(country).has(city)) {
                data.get(country).set(city, price);
            }
            else {
                if (data.get(country).get(city) > price) {
                    data.get(country).set(city, price);
                }
            }
        }
    }

    let sortedCountry = new Map(
        Array
            .from(data)
            .sort((a, b) => {
                return a[0].localeCompare(b[0]);
            })
    );
    let arrayCountry = Array.from(sortedCountry);
    let result = '';
    for (let i = 0; i < arrayCountry.length; i++) {
        let sortedCityMap = Array.from(arrayCountry[i][1]).sort((a, b) => a[1] - b[1]);
        result += `${arrayCountry[i][0]} -> `;
        for (let j = 0; j < sortedCityMap.length; j++) {
            let city = sortedCityMap[j].join(' -> ');
            result += `${city} `;
        }
        result += '\n';
    }
    console.log(result);
}

travelData(["Bulgaria > Sofia > 25000",
    "Bulgaria > Sofia > 25000",
    "Kalimdor > Orgrimar > 25000",
    "Albania > Tirana > 25000",
    "Bulgaria > Aarna > 25010",
    "Bulgaria > Lukovit > 10"]
);