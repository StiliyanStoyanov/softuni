function assignProperties([keyName, name, keyAge, age, keyGender, gender]) {
    let obj = {
        [keyName]: name,
        [keyAge]: age,
        [keyGender]: gender
    };
    console.log(obj);
}

assignProperties(['name', 'Pesho', 'age', '23', 'gender', 'male']);