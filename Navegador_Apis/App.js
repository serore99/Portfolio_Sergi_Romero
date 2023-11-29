import { createStackNavigator } from '@react-navigation/stack';
import { NavigationContainer } from '@react-navigation/native';

import Home from './src/screens/home';
import Screen1 from './src/screens/screen1';
import Screen2 from './src/screens/screen2';

const Stack = createStackNavigator();
const App = () => (
  <NavigationContainer>
    <Stack.Navigator options="false">
      <Stack.Screen name="Home" component={Home} />
      <Stack.Screen name="Screen1" component={Screen1} />
      <Stack.Screen name="Screen2" component={Screen2} />
    </Stack.Navigator>
  </NavigationContainer>
);

export default App;
