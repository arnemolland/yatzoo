import React, {Component} from 'react'
import {HubConnection} from '@aspnet/signalr'

class YatzooLobby extends Component {
	componentDidMount = () => {
		const nick = window.prompt('Your name:', 'John');

		const hubConnection = new HubConnection('http://localhost:5000/lobby')

		this.setState({hubConnection, nick}, () => {
			this.state.hubConnection
				.start()
				.then(() => console.log('Connection started with Lobby Hub!'))
				.catch(err => console.log('Error while establishing connection with Lobby Hub:('))

			this.state.hubConnection.on('sendToAll', (nick, receivedMessage) => {
				const text = `${nick}: ${receivedMessage}`
				const messages = this.state.messages.concat([text])
				this.setState({messages})
			})
		})
	}

	render() {
		return (
			<div>
				<p>Make a lobby or join one.</p>

				<input type="text" value="Lobby name"></input>
				<button>Make lobby</button>
			</div>
		)
	}
}

export default YatzooLobby
