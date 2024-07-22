// document.addEventListener("DOMContentLoaded", () => {
//     const firstinp = document.getElementById('textinp')
//     const secondinp = document.getElementById('textinp2')
//     const operation = document.getElementById('op')
//     const taskList = document.getElementById('tasklist')

//     btnresult.addEventListener('click', calculateResult)

//     function calculateResult() {
//         const num1 = parseFloat(firstinp.value)
//         const num2 = parseFloat(secondinp.value)
//         const op = operation.value

//         let result;

//         switch (op) {
//             case 'Add':
//                 result = num1 + num2
//                 break
//             case 'sub':
//                 result = num1 - num2
//                 break
//             case 'mul':
//                 result = num1 * num2
//                 break
//             case 'div':
//                 result = num1 / num2
//                 break
//             default:
//                 console.log("enter the valid input")
//                 break;
//         }

//         Displayresult(result)

//         function Displayresult(result) {
//             const resultItem = document.getElementById('li')
//             resultItem.textContent = `Result: ${result}`;
//             taskList.appendChild(resultItem);
//         }
//     }
// })




document.addEventListener('DOMContentLoaded', () => {
    const firstInput = document.getElementById('textinp');
    const secondInput = document.getElementById('textinp2');
    const operationSelect = document.getElementById('op');
    const resultButton = document.getElementById('btnresult');
    const taskList = document.getElementById('tasklist');

    resultButton.addEventListener('click', calculateResult);

    function calculateResult() {
        const num1 = parseFloat(firstInput.value);
        const num2 = parseFloat(secondInput.value);
        const operation = operationSelect.value;

        let result;

        switch (operation) {
            case 'Add':
                result = num1 + num2;
                break;
            case 'Sub':
                result = num1 - num2;
                break;
            case 'Mul':
                result = num1 * num2;
                break;
            case 'Div':
                if (num2 !== 0) {
                    result = num1 / num2;
                } else {
                    alert('Division by zero is not allowed.');
                    return;
                }
                break;
            default:
                alert('Please choose a valid operation.');
                return;
        }

        displayResult(result);
    }

    function displayResult(result) {
        const resultItem = document.createElement('li');
        resultItem.textContent = `Result: ${result}`;
        taskList.appendChild(resultItem);
    }
});
