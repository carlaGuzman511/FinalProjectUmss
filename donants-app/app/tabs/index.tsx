import { View, StyleSheet, Platform, Text, FlatList } from 'react-native';
// import * as ImagePicker from 'expo-image-picker';
// import React, { useState, useEffect, useRef } from 'react';
// import { GestureHandlerRootView } from 'react-native-gesture-handler';
// import * as MediaLibrary from 'expo-media-library';
// import { type ImageSource } from 'expo-image';
// import { captureRef } from 'react-native-view-shot';
// import domtoimage from 'dom-to-image';
// import axios from 'axios';

// import Button from '@/components/Button';
// import ImageViewer from '@/components/ImageViewer';
// import IconButton from '@/components/IconButton';
// import CircleButton from '@/components/CircleButton';
// import EmojiPicker from '@/components/EmojiPicker';
// import EmojiList from '@/components/EmojiList';
// import EmojiSticker from '@/components/EmojiSticker';
// import CardViewer from '@/components/CardViewer';
// import Form from '@/components/Form';
// import { Post } from '@/models/App.types';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import GetStarted from './screens/GetStarted';
import Home from './screens/Home';
import Login from './screens/Login';
import OPTVerification from './screens/OPTVerification';
import Register from './screens/Register';
import ResetPassword from './screens/ResetPassword';
import SuccessVerification from './screens/SuccessVerification';
import OnBoardingStarter from './screens/OnBoardingStarter';

// export {
//   GetStarted,
//   Home,
//   Login,
//   OnBoardingStarter,
//   OPTVerification,
//   Register,
//   ResetPassword,
//   SuccessVerification
// };

export default function Index() {
  const Stack = createNativeStackNavigator();
  // const [hideForm, setHideForm] = useState<boolean>(true);
  // const API_URL = 'http://localhost:7084/api/posts';
  // const [data, setData] = useState([]);
  // useEffect(() => {
  //   fetchData();
  // }, []);
  // const fetchData = async () => {
  //   try {
  //     const response = await axios.get(API_URL);
  //     setData(response.data);
  //   } catch (error) {
  //     console.error('Error fetching data:', error);
  //   }
  // };

  // // Scaffold-DbContext "Server=.\SQLEXPRESS;Database=DBCrudBlazor;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models

  // const onCircleButtonIsPressed = () =>{
  //   setHideForm(false);
  // }

  return (
    <NavigationContainer>
      <Stack.Navigator
        initialRouteName="OnBoardingStarter"
      >
        <Stack.Screen
          name="OnBoardingStarter"
          component={OnBoardingStarter}
          options={{
            headerShown: false
          }}
        />
        <Stack.Screen
          name="GetStarted"
          component={GetStarted}
          options={{
            headerShown: false
          }}
        />
        <Stack.Screen
          name="Home"
          component={Home}
          options={{
            headerShown: false
          }}
        />
        <Stack.Screen
          name="OPTVerification"
          component={OPTVerification}
          options={{
          headerShown: false
        }}
        />
        <Stack.Screen
          name="Register"
          component={Register}
          options={{
            headerShown: false
          }}
        />
        <Stack.Screen
          name="ResetPassword"
          component={ResetPassword}
          options={{
          headerShown: false
        }}
        />
        <Stack.Screen
          name="SuccessVerification"
          component={SuccessVerification}
          options={{
            headerShown: false
          }}
        />
      </Stack.Navigator>
    </NavigationContainer>
  );
};

const styles = StyleSheet.create({
  container: {
    marginTop:70,
    flex: 1,
    justifyContent:'center',
    alignItems:'center',
    padding: 16,
    backgroundColor: '#fff',
  },
  item: {
    // backgroundColor: '#f5f5f5',
    // padding: 10,
    // marginVertical: 8,
    // borderRadius: 8,
  },
});

