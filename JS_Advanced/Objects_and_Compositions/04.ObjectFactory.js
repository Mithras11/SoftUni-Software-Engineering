function factory(library, orders) {
    const products = [];

    for (let order of orders) {
        const currObj = Object.assign({}, order.template);

        for (let part of order.parts) {
            currObj[part] = library[part];
        }

        products.push(currObj);

    }

    return products;


}



const library = {
    print: function () {
        console.log(`${this.name} is printing a page`);
    },
    scan: function () {
        console.log(`${this.name} is scanning a document`);
    },
    play: function (artist, track) {
        console.log(`${this.name} is playing '${track}' by ${artist}`);
    },
};
const orders = [
    {
        template: { name: 'ACME Printer' },
        parts: ['print']
    },
    {
        template: { name: 'Initech Scanner' },
        parts: ['scan']
    },
    {
        template: { name: 'ComTron Copier' },
        parts: ['scan', 'print']
    },
    {
        template: { name: 'BoomBox Stereo' },
        parts: ['play']
    },
];
const products = factory(library, orders);
console.log(products);

///--------//

function factory(library, orders) {
    return orders
        .map(order => Object.assign({},
            order.template,
            order.parts.reduce(
                (acc, val) => Object.assign
                    (acc, { [val]: library[val] }), {})));

}

//-----//
(library, orders) =>
    orders
        .map(order => Object.assign({},
            order.template,
            order.parts.reduce(
                (acc, val) => Object.assign
                    (acc, { [val]: library[val] }), {})))
 
