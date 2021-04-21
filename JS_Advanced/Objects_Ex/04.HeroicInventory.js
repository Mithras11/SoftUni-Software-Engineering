function solve(args) {

    const register = [];

    for (let arg of args) {
        arg = arg.split(' / ')
        let [name, level, items] = arg;
        level = +level; 
        items = items ? items.split(', '):[];

        const hero = {
            name,
            level,
            items
        }

        register.push(hero)

    }

    return JSON.stringify(register);

}

console.log(solve(['Isacc / 25 ',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']));

console.log(solve(['Jake / 1000 / Gauss, HolidayGrenade']));