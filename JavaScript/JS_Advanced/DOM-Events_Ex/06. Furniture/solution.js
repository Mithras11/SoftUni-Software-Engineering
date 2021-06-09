function solve() {

    let generateBtn = document.getElementsByTagName('button')[0];
    generateBtn.addEventListener('click', onClickGenerate);

    let buyBtn = document.getElementsByTagName('button')[1];
    buyBtn.addEventListener('click', onClickBuy);



    function onClickGenerate(event) {

        let input = document.getElementsByTagName('textarea')[0].value;
        let arr = JSON.parse(input);
        let table = document.querySelector('.table tbody');


        for (const obj of arr) {

            let newTr = document.createElement('tr');
            table.appendChild(newTr);

            let img = document.createElement('td');
            img.innerHTML = '<img src="' + obj.img + '"/>';
            newTr.appendChild(img);

            let name = document.createElement('td');
            name.textContent = `${obj.name}`;
            newTr.appendChild(name);

            let price = document.createElement('td');
            price.textContent = `${obj.price}`;
            newTr.appendChild(price);

            let decFactor = document.createElement('td');
            decFactor.textContent = `${obj.decFactor}`;
            newTr.appendChild(decFactor);

            let mark = document.createElement('td');
            mark.innerHTML = '<input type="checkbox" />';
            newTr.appendChild(mark);

        }
    }


    function onClickBuy(event) {

        let checkboxes = Array.from(document.querySelectorAll('input[type="checkbox"]'));
        let names = [];
        let totalPrice = 0;
        let avgDecFactor = 0;

        for (const box of checkboxes) {

            let parent = box.parentNode.parentNode.getElementsByTagName('td');

            if (box.checked === true) {

                let name = parent[1].textContent;
                let price = Number(parent[2].textContent);
                let decFactor = Number(parent[3].textContent);

                names.push(name);
                totalPrice += price;
                avgDecFactor += decFactor;

            }
        }

        let result = `Bought furniture: ${names.join(', ')}\n`;

        result += `Total price: ${totalPrice.toFixed(2)}\n`;

        avgDecFactor /= names.length;

        result += `Average decoration factor: ${avgDecFactor}`;

        let ouput = document.getElementsByTagName('textarea')[1];

        ouput.textContent = result;


    }

}


//----different approach-----//

function solve() {

    const [input, output] = document.querySelectorAll('textarea');
    const table = document.querySelector('table.table tbody');
    const [generateBtn, buyBtn] = [...document.querySelectorAll('button')];

    const furniture = [];

    generateBtn.addEventListener('click', () => {

        const furnitureArr = JSON.parse(input.value.trim());

        furnitureArr.forEach(f => {

            const item = createRow(f);

            furniture.push(item);
            table.appendChild(item.element);

        });


    });


    buyBtn.addEventListener('click', () => {

        let names = [];
        let totalPrice = 0;
        let avgDecFactor = 0;

        furniture.filter(f => f.isChecked())
            .forEach(f => {

                const values = f.getValues();

                names.push(values.name);
                totalPrice += +(values.price);
                avgDecFactor += +(values.decFactor);
            });

        let result = `Bought furniture: ${names.join(', ')}\n`;

        result += `Total price: ${totalPrice.toFixed(2)}\n`;

        avgDecFactor /= names.length;

        result += `Average decoration factor: ${avgDecFactor}`;


        output.textContent = result;

    });

    const td = createElem.bind(null, 'td');
    const p = createElem.bind(null, 'p');

    function createRow(data) {

        const img = createElem('img');
        img.src = data.img;

        const check = createElem('input');
        check.type = 'checkbox';

        const element = createElem('tr',
            td(img),
            td(p(data.name)),
            td(p(data.price)),
            td(p(data.decFactor)),
            td(check));

        return {
            element,
            isChecked,
            getValues,
        }


        function isChecked() {
            return check.checked;
        }

        function getValues() {
            return data;
        }

    }

    function createElem(type, ...content) {

        const result = document.createElement(type);

        content.forEach(e => {

            if (typeof e === 'string') {
                const node = document.createTextNode(e);

                result.appendChild(node);

            } else {
                result.appendChild(e);
            }
        })

        return result;
    };



}