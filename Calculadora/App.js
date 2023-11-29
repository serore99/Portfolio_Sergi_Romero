import React, { useState } from 'react';
import {
  Text,
  View,
  TouchableOpacity,
  StyleSheet,
  TextInput,
} from 'react-native';

// Función para convertir grados a radianes
Math.radians = function (degrees) {
  return (degrees * Math.PI) / 180;
};

function factorial(num) {
  if (num == 0 || num == 1) {
    return 1;
  } else {
    return num * factorial(num - 1);
  }
}

const buttons = [
  ['sen', 'cos', 'tan', 'deg'],
  ['ln', 'log', 'π', 'rad'],
  ['1/X', '!', '√', '/'],
  ['7', '8', '9', 'x'],
  ['4', '5', '6', '-'],
  ['1', '2', '3', '+'],
  ['C', '0', ',', '='],
];

export default function App() {
  const [result, setResult] = useState('0');
  const [firstOperand, setFirstOperand] = useState('');
  const [operator, setOperator] = useState('');

  const handleButtonPress = (text) => {
    let num;
    switch (text) {
      case 'sen':
        num = result.replace(',', '.');
        num = Math.sin(num);
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case 'cos':
        num = result.replace(',', '.');
        num = Math.cos(num);
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case 'tan':
        num = result.replace(',', '.');
        num = Math.tan(num);
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case 'deg':
        num = result.replace(',', '.');
        num = (num * 180) / Math.PI;
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case 'ln':
        num = result.replace(',', '.');
        num = Math.log(num);
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case 'log':
        num = result.replace(',', '.');
        num = Math.log10(num);
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case 'π':
        num = Math.PI;
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case 'rad':
        num = result.replace(',', '.');
        num = (num * Math.PI) / 180;
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case '1/X':
        num = result.replace(',', '.');
        num = 1 / num;
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case '!':
        num = factorial(result);
        setResult(num.toString().substring(0, 11));
        break;
      case '√':
        num = result.replace(',', '.');
        num = Math.sqrt(num);
        setResult(
          parseFloat(num).toString().substring(0, 11).replace('.', ',')
        );
        break;
      case '/':
      case 'x':
      case '-':
      case '+':
        setOperator(text);
        setFirstOperand(result.replace(',', '.'));
        setResult('');
        break;
      case '=':
        if (operator === '/') {
          num = parseFloat(firstOperand) / parseFloat(result.replace(',', '.'));
          setResult(
            parseFloat(num).toString().substring(0, 11).replace('.', ',')
          );
        } else if (operator === 'x') {
          num = parseFloat(firstOperand) * parseFloat(result.replace(',', '.'));
          setResult(
            parseFloat(num).toString().substring(0, 11).replace('.', ',')
          );
        } else if (operator === '-') {
          num = parseFloat(firstOperand) - parseFloat(result.replace(',', '.'));
          setResult(
            parseFloat(num).toString().substring(0, 11).replace('.', ',')
          );
        } else if (operator === '+') {
          num = parseFloat(firstOperand) + parseFloat(result.replace(',', '.'));
          setResult(
            parseFloat(num).toString().substring(0, 11).replace('.', ',')
          );
        }
        setOperator('');
        setFirstOperand('');
        break;
      case 'C':
        setResult('0');
        num = 0;
        setFirstOperand('');
        setOperator('');
        break;
      case ',':
        if (!result.includes(',')) {
          setResult((result + text).substring(0,11));
        }
        break;
      default:
        if (result === '0') {
          setResult(text);
        } else {
          setResult((result + text).substring(0,11));
        }
        break;
    }
  };

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Calculadora</Text>
      <TextInput style={styles.result} value={result} editable={false} />
      <View style={styles.buttonContainer}>
        {buttons.map((row, rowIndex) => (
          <View key={rowIndex} style={styles.row}>
            {row.map((text, colIndex) => (
              <TouchableOpacity
                key={colIndex}
                style={[
                  styles.button,
                  !isNaN(text) && { backgroundColor: 'blue' },
                ]}
                onPress={() => handleButtonPress(text)}>
                <Text>{text}</Text>
              </TouchableOpacity>
            ))}
          </View>
        ))}
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    justifyContent: 'center',
    alignSelf: 'center',
    marginVertical: 80,
  },
  title: {
    fontSize: 45,
    fontWeight: 'bold',
    textAlign: 'center',
  },
  result: {
    fontSize: 30,
    textAlign: 'right',
    marginVertical: 10,
    paddingHorizontal: 10,
    borderWidth: 1,
    borderColor: 'gray',
    borderRadius: 8,
  },
  buttonContainer: {
    marginTop: 3,
  },
  row: {
    flexDirection: 'row',
    marginBottom: 4,
  },
  button: {
    flex: 1,
    padding: 3,
    borderRadius: 8,
    justifyContent: 'center',
    alignItems: 'center',
    textAlignVertical: 'center',
    width: 75,
    height: 75,
    backgroundColor: 'gray',
  },
});
