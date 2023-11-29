import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { NavigationContainer } from '@react-navigation/native';

import Screen1 from './src/screens/screen1';
import Screen2 from './src/screens/screen2';

const Tab = createBottomTabNavigator();
const APP = () => (
<NavigationContainer>
<Tab.Navigator screenOptions={{headerShown:false}}>
<Tab.Screen name="Screen1" component={Screen1} />
<Tab.Screen name="Screen2" component={Screen2} />
</Tab.Navigator>
</NavigationContainer>
);

export default APP;
