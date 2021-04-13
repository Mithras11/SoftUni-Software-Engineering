function stringLentgh(str1, str2, str3) {

    let totalLength = str1.length + str2.length + str3.length;
    let averageLength = Math.floor(totalLength / 3);

    console.log(totalLength);
    console.log(averageLength);


}

stringLentgh('chocolate', 'ice cream', 'cake');
stringLentgh('pasta', '5', '22.3');