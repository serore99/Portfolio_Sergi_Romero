import { View, Text, TextInput, Button, ScrollView } from 'react-native';
import React, { useState } from 'react';

const Tab2 = () => {
  const [players, setPlayers] = useState([]);
  const [searchTerm, setSearchTerm] = useState('');
  const [page, setPage] = useState(0);
  const [totalPages, setTotalPages] = useState(0);

  const handleSearch = async () => {
    try {
      const response = await fetch(
        `https://www.balldontlie.io/api/v1/players?page=${page}&per_page=25&search=${searchTerm}`
      );

      if (response.ok) {
        const data = await response.json();
        setPlayers(data.data);
        setTotalPages(data.meta.total_pages);
      }
    } catch (error) {
      console.log(error);
    }
  };

  const handleNextPage = async () => {
    setPage((prevPage) => prevPage + 1);
    try {
      const response = await fetch(
        `https://www.balldontlie.io/api/v1/players?page=${
          page + 1
        }&per_page=25&search=${searchTerm}`
      );

      if (response.ok) {
        const data = await response.json();
        setPlayers([...data.data]);
        if (page == totalPages - 1) {
          setPage(-1);
        }
      }
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <View>
      <View style={{ flexDirection: 'row', justifyContent: 'center' }}>
        <TextInput
          style={{
            height: 40,
            backgroundColor: 'blue',
            color: 'white',
            padding: 10,
            fontSize: 20,
          }}
          onChangeText={(text) => setSearchTerm(text)}
          value={searchTerm}
        />
        <Button onPress={handleSearch} title="Buscar" />
      </View>
      <ScrollView>
        {players.map((player) => (
          <View key={player.id}>
            <Text>
              {player.first_name} {player.last_name}
            </Text>
          </View>
        ))}
        {players.length > 0 && (
          <Button onPress={handleNextPage} title="Siguiente" />
        )}
      </ScrollView>
    </View>
  );
};

export default Tab2;
