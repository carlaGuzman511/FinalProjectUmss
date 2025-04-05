import { NavigationContainer } from '@react-navigation/native'
import { createNativeStackNavigator } from '@react-navigation/native-stack'
import { Tabs } from 'expo-router'
import Ionicons from '@expo/vector-icons/Ionicons'

const Stack = createNativeStackNavigator();

export default function TabLayout() {
  return (
    <></>
    // <Tabs
    //   screenOptions={{
    //     tabBarActiveTintColor: '#ffd33d',
    //     headerStyle: {
    //       backgroundColor: '#25292e',
    //     },
    //     headerShadowVisible: false,
    //     headerTintColor: '#fff',
    //     tabBarStyle: {
    //       backgroundColor: '#25292e',
    //     },
    //   }}
    // >
    //   <Tabs.Screen
    //     name="index"
    //     options={{
    //       title: 'Home',
    //       tabBarIcon: ({ color, focused }) => (
    //         <Ionicons name={focused ? 'home-sharp' : 'home-outline'} color={color} size={24} />
    //       ),
    //     }}
    //   />
    //   <Tabs.Screen
    //     name="about"
    //     options={{
    //       title: 'About',
    //       tabBarIcon: ({ color, focused }) => (
    //         <Ionicons name={focused ? 'information-circle' : 'information-circle-outline'} color={color} size={24}/>
    //       ),
    //     }}
    //   />
    //   <Tabs.Screen
    //     name="onboardingstarter"
    //     options={{
    //       title: 'OnBoardingStarter',
    //       tabBarIcon: ({ color, focused }) => (
    //         <Ionicons name={focused ? 'information-circle' : 'information-circle-outline'} color={color} size={24}/>
    //       ),
    //     }}
    //   />
    //   <Tabs.Screen
    //     name="OPTVerification"
    //     options={{
    //       title: 'OPTVerification',
    //       tabBarIcon: ({ color, focused }) => (
    //         <Ionicons name={focused ? 'information-circle' : 'information-circle-outline'} color={color} size={24}/>
    //       ),
    //     }}
    //   />
    //   <Tabs.Screen
    //     name="login"
    //     options={{
    //       title: 'Login',
    //       tabBarIcon: ({ color, focused }) => (
    //         <Ionicons name={focused ? 'information-circle' : 'information-circle-outline'} color={color} size={24}/>
    //       ),
    //     }}
    //   />
    //   <Tabs.Screen
    //     name="SuccessVerification"
    //     options={{
    //       title: 'SuccessVerification',
    //       tabBarIcon: ({ color, focused }) => (
    //         <Ionicons name={focused ? 'information-circle' : 'information-circle-outline'} color={color} size={24}/>
    //       ),
    //     }}
    //   />
    // </Tabs>
  );
}


// import { NavigationContainer } from '@react-navigation/native';
// import { createNativeStackNavigator } from '@react-navigation/native-stack';
// import { Tabs } from 'expo-router';
// import { useFonts } from 'expo-font';
// import * as SplashScreen from 'expo-splash-screen';
// import Ionicons from '@expo/vector-icons/Ionicons';
// import OnBoardingStarter from './screens/OnBoardingStarter';
// import GetStarted from './screens/GetStarted';
// import Home from './screens/Home';
// import SuccessVerification from './screens/SuccessVerification';
// import ResetPassword from './screens/ResetPassword';
// import Register from './screens/Register';
// import OPTVerification from './screens/OPTVerification';
// import Login from './screens/Login';

// SplashScreen.preventAutoHideAsync();
// const Stack = createNativeStackNavigator();

// export default function TabLayout() {
//   // const [fontsLoaded] = useFonts();
//   return (
//     <NavigationContainer>
//       <Stack.Navigator 
//         initialRouteName='OnboardingStarter'
//       >
//         <Stack.Screen
//           name='OnboardingStarter'
//           component={OnBoardingStarter}
//           options={{
//             headerShown: false
//           }}
//         />
//         <Stack.Screen
//           name='GetStarted'
//           component={GetStarted}
//           options={{
//             headerShown: false
//           }}
//         />
//         <Stack.Screen
//           name='Home'
//           component={Home}
//           options={{
//             headerShown: false
//           }}
//         />
//         <Stack.Screen
//           name='Register'
//           component={Register}
//           options={{
//             headerShown: false
//           }}
//         />
//         <Stack.Screen
//           name='ResetPassword'
//           component={ResetPassword}
//           options={{
//             headerShown: false
//           }}
//         />
//         <Stack.Screen
//           name='SuccessVerification'
//           component={SuccessVerification}
//           options={{
//             headerShown: false
//           }}
//         />
//         <Stack.Screen
//           name='Login'
//           component={Login}
//           options={{
//             headerShown: false
//           }}
//         />
//         <Stack.Screen
//           name='OPTVerification'
//           component={OPTVerification}
//           options={{
//             headerShown: false
//           }}
//         />
//       </Stack.Navigator>
//     </NavigationContainer>
//   );
// }
