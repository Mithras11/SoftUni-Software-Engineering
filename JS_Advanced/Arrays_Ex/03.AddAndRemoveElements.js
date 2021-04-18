function solve(commands = []) {
    let arr = [];
    let num = 1;

    for (let command of commands) {
        
        if (command === 'add') {
            arr.push(num);
        } else {
            arr.pop()
        }

        num++;

    }

    if (arr.length === 0){
        return 'Empty';
    }else{
        return arr.join('\n');
    }
}

console.log(solve(['add',
    'add',
    'add',
    'add']));

console.log(solve(['remove',
    'remove',
    'remove']));

console.log(solve(['add',
    'add',
    'remove',
    'add',
    'add']));