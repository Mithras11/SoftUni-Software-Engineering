function solve(arr) {

    let juices = {};
    let bottles = {};

    arr.forEach(item => {

        const [name, quantity] = item.split(' => ');

        if (!juices[name]) {
            juices[name] = 0;

        }
        juices[name] += Number(quantity);



        let currBottles = Math.trunc(juices[name] / 1000);

        if (currBottles > 0) {
            if (!bottles[name]) {
                bottles[name] = 0;

            }
            bottles[name] += currBottles;

        }

        juices[name] -= currBottles * 1000;;


    });


    return Object.entries(bottles).map(([k, v]) => `${k} => ${v}`).join('\n');

}


let arr1 = ['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549'
];

solve(arr1);