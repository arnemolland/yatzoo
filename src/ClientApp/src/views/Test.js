import React, {Component} from 'react'
import {HubConnectionBuilder, LogLevel} from '@aspnet/signalr'

class Test extends Component {

	constructor(props) {
		super(props)

		this.state = {
			nick: '',
			message: '',
			messages: [],
			hubConnection: null,
		}
	}

	sendMessage = () => {
		this.state.hubConnection
			.invoke('sendMessage', this.state.nick, this.state.message)
			.then(() => this.setState({message: ''}))
			.catch(err => console.error(err))
	}

	componentDidMount = () => {
		const nick = "John" //window.prompt('Your name:', 'John');

		const hubConnection = new HubConnectionBuilder()
			.configureLogging(LogLevel.Trace)
			.withUrl('https://localhost:5001/testhub')
			.build()

		this.setState({hubConnection, nick}, () => {
			this.state.hubConnection
				.start({credentials: false})
				.then(() => console.log('Connection started with Hub!'))
				.catch(err => console.log('Error while establishing connection with Hub:(' + err.message))

			this.state.hubConnection.on('broadcastMessage', (nick, receivedMessage) => {
				const text = `${nick}: ${receivedMessage}`
				const messages = this.state.messages.concat([text])
				this.setState({messages})
			})
		})
	}

	render() {
		return (
			<div>
				<h1>Test</h1>

				<input
					type="text"
					value={this.state.message}
					onChange={e => this.setState({message: e.target.value})}
				/>

				<button onClick={this.sendMessage}>Send</button>

				<div>
					{this.state.messages.map((message, index) => (
						<span style={{display: 'block'}} key={index}> {message} </span>
					))}
				</div>
			</div>
		)
	}
}

export default Test
