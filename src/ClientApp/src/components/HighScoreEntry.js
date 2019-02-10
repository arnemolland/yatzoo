import React, {Component} from 'react'

class HighScoreEntry extends Component {

	render() {
		const name = this.props.name
		const score = this.props.score

		return (
			<tr>
				<td>{name}</td>
				<td>{score}</td>
			</tr>
		)
	}
}

export default HighScoreEntry
