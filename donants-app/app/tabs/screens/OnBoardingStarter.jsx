import {View, Text, Image, TouchableOpacity} from 'react-native'
import React from 'react'
import Onboarding from 'react-native-onboarding-swiper'

const Dots = ({selected}) => {
    let backgroundColor = selected ? "#ff2156" : "#808080";
    return(
        <View
            style={{
                height: 5,
                width: 5,
                marginHorizontal: 3,
                backgroundColor
            }}
        />
    )
}
const Done = ({ ...props }) => (
    <TouchableOpacity
        style={{
            marginRight: 12,
        }}
    >
        <Text style={{color:'#ff2156'}}>Done</Text>
    </TouchableOpacity>
)


const OnBoardingStarter = ({navigation}) => {
    return(
        <Onboarding
            onSkip={() => navigation.navigate('GetStarted')}
            onDone={() => navigation.navigate('GetStarted')}
            DotComponent={Dots}
            bottomBarColor="#ffffff"
            DoneButtonComponent={Done}
            pages={[{
                backgroundColor: '#fff',
                image: <Image source={require('../../../assets/images/heart-donation.png')} />,
                title: 'Find Blood Donors',
                subtitle: 'Done with React Native Onboard Swiper'
            }]}
        />
    )
}

export default OnBoardingStarter;