const date = document.getElementById('date');
const balance = document.getElementById('balance');
const income = document.getElementById('income');
const expense = document.getElementById('expense');

const form = document.getElementById('form');
const text = document.getElementById('text');
const amount = document.getElementById('amount');
const type = document.getElementById('type');

const incomeList = document.getElementById('incomeList');
const expenseList = document.getElementById('expenseList');

let transactions = JSON.parse(localStorage.getItem('transactions')) || [];

/* ADD TRANSACTION */
form.addEventListener('submit', function(e) {
    e.preventDefault();

    let amt = +amount.value;

    // dropdown logic
    if (type.value === "expense") {
        amt = -Math.abs(amt);
    } else {
        amt = Math.abs(amt);
    }

    const transaction = {
        id: Date.now(),
        text: text.value,
        amount: amt,
        date: date.value
    };

    transactions.push(transaction);

    updateLocalStorage();
    init();

    text.value = '';
    amount.value = '';
    date.value = '';
});

/* LOCAL STORAGE */
function updateLocalStorage() {
    localStorage.setItem('transactions', JSON.stringify(transactions));
}

/* INIT */
function init() {
    incomeList.innerHTML = '';
    expenseList.innerHTML = '';

    transactions.forEach(addToDOM);
    updateValues();
    updateChart();
}

/* UPDATE VALUES */
function updateValues() {
    const amounts = transactions.map(t => t.amount);

    const total = amounts.reduce((a, b) => a + b, 0).toFixed(2);
    const inc = amounts.filter(a => a > 0)
        .reduce((a, b) => a + b, 0).toFixed(2);
    const exp = (amounts.filter(a => a < 0)
        .reduce((a, b) => a + b, 0) * -1).toFixed(2);

    balance.innerText = total;
    income.innerText = inc;
    expense.innerText = exp;
}

/* ADD TO DOM */

function addToDOM(transaction) {
    const li = document.createElement('li');

   li.innerHTML = `
    <button class="delete-btn" onclick="removeTransaction(${transaction.id})">❌</button>
    ${transaction.text} 
    <small>(${transaction.date})</small>
    <span>₹${Math.abs(transaction.amount)}</span>
`;

    if (transaction.amount > 0) {
        incomeList.appendChild(li);
    } else {
        expenseList.appendChild(li);
    }
}

/* RESET */
function resetAll() {
    if (confirm("Are you sure? Sab data delete ho jayega!")) {
        transactions = [];
        updateLocalStorage();
        init();
    }
}

/* CHART */
let chart;

function updateChart() {
    const inc = transactions.filter(t => t.amount > 0)
        .reduce((a, b) => a + b.amount, 0);

    const exp = transactions.filter(t => t.amount < 0)
        .reduce((a, b) => a + b.amount, 0);

    if (chart) chart.destroy();

    const ctx = document.getElementById('chart').getContext('2d');

    chart = new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['Income', 'Expense'],
            datasets: [{
                data: [inc, Math.abs(exp)],
                backgroundColor: ['green', 'red']
            }]
        }
    });
}

/* PAGE LOAD */
init();

function removeTransaction(id) {
    transactions = transactions.filter(t => t.id !== id);

    updateLocalStorage();
    init();
}

function toggleDark() {
    document.body.classList.toggle("dark");
}
