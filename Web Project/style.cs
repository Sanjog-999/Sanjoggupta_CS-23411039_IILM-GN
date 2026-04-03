
body {
    font-family: Arial;
    background: #f4f4f4;
    margin: 0;
    padding: 0;  
}

.container {
    width: 100%;
    max-width: 1450px;
    margin: 0 auto;
    padding: 30px;
    background: white;   
    border-radius: 0;
}

h1 {
    text-align: center;
}

/* Default (Mobile) */
h3 {
    text-align: left;   
}

/* Desktop ke liye */
@media (min-width: 768px) {
    h3 {
        text-align: center;  
        font-size: 24px; 
    }
}

form {
    display: flex;
    flex-wrap: wrap;
    justify-content: center;  
    gap: 15px;
    margin-top: 20px;
}

form input,
form select {
    width: 200px;
}

.balance-box {
    text-align: center;
    margin: 20px 0;
}

.summary {
    display: flex;
    justify-content: space-around;
    text-align: center;
}

.income-box {
    color: green;
}

.expense-box {
    color: red;
}

form {
    display: flex;
    flex-direction: column;
    gap: 10px;
}

input, button {
    padding: 10px;
    font-size: 16px;
}

button {
    background: black;
    color: white;
    border: none;
    cursor: pointer;
}

ul {
    list-style: none;
    padding: 0;
}

li {
    background: #eee;
    margin: 5px 0;
    padding: 10px;
    display: flex;
    justify-content: space-between;
}

li {
    transition: 0.3s;
}

li:hover {
    transform: scale(1.02);
}


/* Responsive */
@media (max-width: 600px) {
    .summary {
        flex-direction: column;
        align-items: center;
    }
}


.reset-btn {
    background: red;
    color: white;
    margin-top: 10px;
}


.history-container {
    display: flex;
    justify-content: space-between;
    gap: 10px;
}

.history-container div {
    width: 100%;
}

@media (min-width: 768px) {
    .history-container div {
        width: 48%;
    }
}


.history-container ul {
    background: #f9f9f9;
    padding: 10px;
    border-radius: 8px;
}

/* Responsive */
@media (max-width: 600px) {
    .history-container {
        flex-direction: column;
    }
}

/* delete button */
.delete-btn {
    background: pink;
    color: white;
    border: none;
    margin-right: 10px;
    cursor: pointer;
    padding: 5px;
    border-radius: 5px;
}

small {
    color: gray;
    margin-left: 5px;
    font-size: 12px;
}


@media (min-width: 768px) {
    
    .summary {
        justify-content: space-around;
    }

    .history-container {
        display: flex;
        gap: 30px;
    }

    .history-container div {
        width: 50%;
    }

    form {
        max-width: 600px;
        margin: auto;
    }

    canvas {
        max-width: 500px;
        margin: auto;
        display: block;
    }
}




body {
    background: linear-gradient(to right, #ece9e6, #ffffff);
}

.container {
    padding: 30px;
    border-radius: 15px;
}



@media (min-width: 768px) {

    form {
        flex-direction: row;
        flex-wrap: wrap;
        gap: 15px;
        justify-content: space-between;
    }

    form input,
    form select {
        width: 23%;
    }

    form button {
        width: 100%;
    }
}



.balance-box {
    text-align: center;
    margin-left: 50px;   
}



.title-box {
    background: black;
    color: white;
    padding: 15px;
    text-align: center;
    border-radius: 0px;
    margin-bottom: 10px;
}

.title-box h1 {
    margin: 0;
    font-size: 28px;
}



.amount {
    white-space: nowrap;
    font-weight: bold;
}    

.history-container div {
    padding: 10px 15px;
}


/* dark balance */

.dark {
    background: #121212;
    color: white;
}

/* container dark */
.dark .container {
    background: #1e1e1e;
}

/* summary boxes */
.dark .income-box {
    color: #00ff88;
}

.dark .expense-box {
    color: #ff4d4d;
}

/* list items */
.dark li {
    background: #2a2a2a;
}

/* history box */
.dark .history-container ul {
    background: #2a2a2a;
}

/* input fields */
.dark input,
.dark select {
    background: #333;
    color: white;
    border: 1px solid #555;
}

/* button */
.dark button {
    background: #444;
    color: white;
}

/* title box */
.dark .title-box {
    background: black;
    color: white;
}


.dark .balance-box {
    color: #00ffcc;
}

.dark .history-box {
    background: #2a2a2a;
}

.dark .history-container div {
    background: #2a2a2a;   /* dark background */
    color: white;          /* text visible */
    border: 1px solid #444;
}

.dark .graph-box {
    background: #1e1e1e;
    border: 1px solid #444;
}

.dark .graph-title {
    border-bottom: 1px solid #444;
}





.history-box {
    background: #ffffff;
    padding: 25px;
    border-radius: 15px;
    margin-top: 30px;

    border: 2px solid #ddd;              
    box-shadow: 0 10px 25px rgba(0,0,0,0.15); /*   strong shadow */
}

.history-box h3 {
    margin-bottom: 20px;
    padding-bottom: 10px;
    border-bottom: 2px solid #ddd;  
}
.history-container div {
    background: #f5f5f5;
    padding: 15px;
    border-radius: 10px;
}
.history-box:hover {
    transform: scale(1.01);
    transition: 0.3s;
}





/* Graph Box */
.graph-box {
    background: #ffffff;
    padding: 25px;
    border-radius: 15px;
    margin-top: 30px;

    border: 2px solid #ddd;
    box-shadow: 0 10px 25px rgba(0,0,0,0.15);
}

/* Graph Title */
.graph-title {
    text-align: center;
    font-size: 30px;   
    margin-bottom: 20px;

    padding-bottom: 10px;
    border-bottom: 2px solid #ddd;
}

/* Graph Center */
.graph-box canvas {
    display: block;
    margin: auto;
    max-width: 400px;
}


body {
    position: relative;
}


.dark-toggle {
    position: absolute;   /* 🔥 change */
    top: 65px;
    right: 0px;

    z-index: 9999;
}
