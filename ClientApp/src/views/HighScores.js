import React, {Component} from 'react'
import HighScoreTable from '../components/HighScoreTable'

class HighScores extends Component {
	constructor(props) {
		super(props)
		this.state = {
			highscores: [], loading: true
		};

		/*
		fetch('api/highscores')
			.then(response => response.json())
			.then(data => {
				this.setState({highscores: data, loading: false});
			});*/

		this.state = {
			highscores: [
				{name: 'Sondre', score: 99999999},
				{name: 'Arne', score: 9999},
				{name: 'Anders', score: 999}
			], 
			loading: false
		}
	}

	render() {
		return (
			<div>
				<h1>High scores</h1>

				{
					this.state.loading
						? <p>Loading...</p>
						: <HighScoreTable highscores={this.state.highscores} />
				}

			</div>
		)
	}
}

export default HighScores
