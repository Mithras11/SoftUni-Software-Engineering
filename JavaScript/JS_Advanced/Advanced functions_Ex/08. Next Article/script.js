function getArticleGenerator(articles) {

    const data = articles;
    let indx = 0;

    let div = document.querySelector('#content');


    return () => {

        if (indx < data.length) {

            div.appendChild(create(data[indx++]))

        };
    }

    function create(content) {
        let result = document.createElement('article');
        let node = document.createTextNode(content);
        result.appendChild(node);

        return result;
    }


}