function heroesInventory(input) {
    let heroes = [];
    for (let i = 0; i < input.length; i++) {
        let currentHero = input[i].split(' / ').filter(x => x !== '').map(x => x.trim());
        let heroName = currentHero[0];
        let heroLevel = Number(currentHero[1]);
        let heroInventory = [];
        if (currentHero.length > 2) {
            heroInventory = currentHero[2].split(',').filter(x => x !== '').map(x => x.trim());
        }
        let hero = {name:heroName, level:heroLevel, items:heroInventory};
        heroes.push(hero);
    }
    console.log(JSON.stringify(heroes));
}

heroesInventory(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']);