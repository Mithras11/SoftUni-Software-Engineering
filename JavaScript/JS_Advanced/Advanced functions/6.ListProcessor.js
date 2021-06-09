function solve(arr) {

    const processor = executeCommand();

    for (const item of arr) {

        if (item === 'print') {

            processor.print();

        } else {
            let [command, str] = item.split(' ');

            if (command === 'add') {

                processor.add(str);

            } else if (command === 'remove') {
                processor.remove(str);
            }
        }

    }


    function executeCommand() {
        let result = [];

        return {
            add,
            remove,
            print
        };

        function add(str) {

            result.push(str);
        }

        function remove(str) {
            result = result.filter(f => f !== str);
        }

        function print() {
            console.log(result.join(','));
        }

    }



}

const arr1 = ['add hello', 'add again', 'remove hello', 'add again', 'print'];
const arr2 = ['add pesho', 'add george', 'add peter', 'remove peter', 'print'];

solve(arr1);
solve(arr2);