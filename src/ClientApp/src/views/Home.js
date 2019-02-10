import React, {Component} from 'react';

import YatzooLobby from '../components/YatzooLobby'
import YatzooGrid from '../components/YatzooGrid'

const gamestate = {
	inLobby: false,
	players: {
		1: null,
		2: null,
		3: null,
		4: null,
		5: null
	},
	rolls: {

	}
}

class Home extends Component {

	render() {
		return (
			<div>
			
				<p>Velkommen til Yatzoo</p>

				{
					gamestate.inLobby === true 
						? <YatzooLobby gamestate={gamestate}/>
						: <YatzooGrid gamestate={gamestate}/>
				}
				
			</div>
		);
	}
}
export default Home
