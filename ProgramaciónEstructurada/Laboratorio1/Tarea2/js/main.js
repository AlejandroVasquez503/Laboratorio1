// Función para formatear el número con o sin decimales
function formatNum(numero, decimales) {
  if (decimales === 'conDecimales') {
    return numero.toLocaleString('en-US', { minimumFractionDigits: 2, maximumFractionDigits: 2 });
  } else {
    return numero.toLocaleString('en-US');
  }
}

// Solicitamos el numero
const numeroUsuario = parseFloat(prompt('Ingresa un número:'));
const decimales = prompt('El número tiene decimales? (responde con "conDecimales" o "sinDecimales"):');

// Verificamos si el número ingresado es válido
if (!isNaN(numeroUsuario)) {
  const resultado = formatNum(numeroUsuario, decimales);
  console.log(`El número formateado es: ${resultado}`);
} else {
  console.log('Ingresa un número válido.');
}

