function arrangeInventory(input) {
    let equipment = input[0].split(' ');
    for (let i = 1; i < input.length; i++) {
        if (input[i] === 'Fight!') {
            break;
        }

        let [command, gear] = input[i].split(' ');
        if (command === 'Buy') {
            if (!equipment.includes(gear)) {
                equipment.push(gear);
            }
        }
        if (command === 'Trash') {
            let gearIndex = equipment.indexOf(gear);
            if (gearIndex !== -1) {
                equipment.splice(gearIndex, 1);
            }
        }
        if (command === 'Repair') {
            let gearIndex = equipment.indexOf(gear);
            if (gearIndex !== -1) {
                equipment.push(gear);
                equipment.splice(gearIndex, 1);
            }
        }
        if (command === 'Upgrade') {
            let upgrade = gear.split('-');
            let upgradeResult = upgrade.join(':');
            let gearIndex = equipment.indexOf(upgrade[0]);
            if (gearIndex !== -1) {
                equipment.splice(gearIndex + 1, 0, upgradeResult);
            }
        }
    }
    console.log(equipment.join(' '));
}


arrangeInventory([
    'SWORD Shield Spear',
    'Buy Bag',
    'Trash Shield',
    'Repair Spear',
    'Upgrade SWORD-Steel',
    'Fight!']
);


// else if (command === 'Trashed') {                Checking if array contains value
//     let current = equipment.indexOf(gear);       -1 = no
//     if (current !== -1) {                         other = the item index found
//         equipment.splice(current, 1);
//     }
// }