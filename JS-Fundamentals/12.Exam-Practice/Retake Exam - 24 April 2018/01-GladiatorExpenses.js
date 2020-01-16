function calcGladiatorExpenses(lostFights, helmetPrice, swordPrice, shieldPrice, armorPrice) {
    let trashedHelmets = Math.floor(lostFights / 2);
    let trashedSwords = Math.floor(lostFights / 3);
    let trashedShields = Math.floor(trashedSwords / 2);
    let trashedArmor = Math.floor(trashedShields / 2);

    let helmetExpenses = trashedHelmets * helmetPrice;
    let swordExpenses = trashedSwords * swordPrice;
    let shieldExpenses = trashedShields * shieldPrice;
    let armorExpenses = trashedArmor * armorPrice;

    let totalExpenses = helmetExpenses + swordExpenses + shieldExpenses + armorExpenses;
    console.log(`Gladiator expenses: ${totalExpenses.toFixed(2)} aureus`);
}


calcGladiatorExpenses(23, 12.5, 21.50, 40, 200);