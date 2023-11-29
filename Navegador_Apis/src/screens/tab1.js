import { View, Text, Image, Button } from 'react-native';
import { useState } from 'react';

const E6 = () => {
  const [data, setData] = useState(null);
  const [characterNumber, setCharacterNumber] = useState(1);

  const getFirst = () => {
    setCharacterNumber(1);
    getData(1);
  };

  const getNextCharacter = () => {
    let nextCharacterNumber =
      characterNumber % 20 === 0 ? characterNumber - 19 : characterNumber + 1;
    setCharacterNumber(nextCharacterNumber);
    getData(nextCharacterNumber);
  };

  const getPreviousCharacter = () => {
    let previousCharacterNumber =
      characterNumber % 20 === 1 ? characterNumber + 19 : characterNumber - 1;
    setCharacterNumber(previousCharacterNumber);
    getData(previousCharacterNumber);
  };

    const get20NextCharacter = () => {
    setCharacterNumber(characterNumber+20);
    getData(characterNumber);
  };

  const get20PreviousCharacter = () => {
    let previous20CharacterNumber =
      characterNumber - 20 > 0 ? characterNumber - 20 : characterNumber;
    setCharacterNumber(previous20CharacterNumber);
    getData(previous20CharacterNumber);
  };

  const getData = async (num) => {
    try {
      const response = await fetch(
        `https://rickandmortyapi.com/api/character/${num}`
      );

      if (response.ok) {
        const data = await response.json();
        setData(data);
      }
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <View>
      <Button onPress={getFirst} title="Ricky y Morty" />
      {data && data.image && (
        <Image
          source={{ uri: data.image }}
          style={{
            width: 300,
            alignSelf: 'center',
            height: 300,
            marginTop: 20,
          }}
        />
      )}
      {data && (
        <View style={{ alignItems: 'center' }}>
          <Text>{data.name}</Text>
          <Text>{data.species}</Text>
          <Text>{data.status}</Text>
        </View>
      )}
      <View style={{ flexDirection: 'row', justifyContent: 'center' }}>
        <Button onPress={getPreviousCharacter} title="Anterior" />
        <Button onPress={getNextCharacter} title="Siguiente" />
      </View>
      <View style={{ flexDirection: 'row', justifyContent: 'center' }}>
        <Button onPress={get20PreviousCharacter} title="Anteriores" />
        <Button onPress={get20NextCharacter} title="Siguientes" />
      </View>
    </View>
  );
};
export default E6;
