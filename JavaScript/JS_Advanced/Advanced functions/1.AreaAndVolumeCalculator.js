function  solve(area,  vol,  input)  {    

    const figures = JSON.parse(input);

    const result = figures.map(f => ({
        'area': area.call(f),
        'volume': vol.call(f),
    }));

    return result;


}


function  area()  {    
    return  Math.abs(this.x  *  this.y);
};

function  vol()  {    
    return  Math.abs(this.x  *  this.y  *  this.z);
};


const example1 = `[
    {"x":"1","y":"2","z":"10"},
    {"x":"7","y":"7","z":"10"},
    {"x":"5","y":"2","z":"10"}
    ]`;

const example2 = `[
        {"x":"10","y":"-22","z":"10"},
        {"x":"47","y":"7","z":"-5"},
        {"x":"55","y":"8","z":"0"},
        {"x":"100","y":"100","z":"100"},
        {"x":"55","y":"80","z":"250"}
        ]`;

solve(area, vol, example1);
solve(area, vol, example2);