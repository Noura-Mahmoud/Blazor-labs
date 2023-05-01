function HatyA5rk() {
    alert("Ana gbt A5ry -_-");
}

function giveMeRandomInt() {
	DotNet.invokeMethodAsync('BlazorApp_customComponent_JSInterop_Identity', 'GenerateRandomInt')
		.then(result => {
			document.getElementById('randomNumSpan').innerText = result
		});
}