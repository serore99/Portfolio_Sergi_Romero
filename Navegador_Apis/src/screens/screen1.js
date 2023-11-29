import { useState } from 'react';
import { Text, View, TextInput, Button } from 'react-native';

const Screen1 = () => {
  const [text, setText] = useState('');
  const [rows, setRows] = useState('');
  const [convertedText, setConvertedText] = useState([]);

  const handleConverter = () => {
    const formatText = text.replace(/\s/g, '').toUpperCase();
    const rowsNumber = parseInt(rows);

    const result = [];

    for (let i = 0; i < rowsNumber; i++) {
      let word = '';

      for (let j = i; j < formatText.length; j += rowsNumber) {
        word += formatText[j];
      }
      result.push(word);
    }

    setConvertedText(result);
    setText('');
    setRows('');
  };

  return (
    <View style={{ flex: 1, justifyContent: 'center' }}>
      <Text>Introduce el texto:</Text>
      <TextInput
        style={{
          height: 40,
          backgroundColor: 'blue',
          color: 'white',
          padding: 10,
          fontSize: 20,
        }}
        value={text}
        onChangeText={(texto) => setText(texto)}
      />
      <Text>Introduce el número de filas:</Text>
      <TextInput
        style={{
          height: 40,
          backgroundColor: 'blue',
          color: 'white',
          padding: 10,
          fontSize: 20,
        }}
        value={rows}
        onChangeText={(filas) => setRows(filas)}
        keyboardType="numeric"
      />
      <View style={{ padding: 20 }}>
        <Button title="Pulsa" onPress={handleConverter}></Button>
      </View>
      {convertedText !== '' && (
        <View style={{ padding: 10 }}>
          {convertedText.map((fila, index) => (
            <Text style={{ fontSize: 20 }} key={index}>
              {fila}
            </Text>
          ))}
        </View>
      )}
    </View>
  );
};

export default Screen1;