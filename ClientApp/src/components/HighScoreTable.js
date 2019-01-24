import React, {Component} from 'react'

import HighScoreEntry from './HighScoreEntry'

class HighScoreTable extends Component {

	render() {
		return (
			<table>
				<tr>
					<th>Navn</th>
					<th>Score</th>
				</tr>

				{
					this.props.highscores
						.map((highscore, index) => <HighScoreEntry name={highscore.name} score={highscore.score} />)
				}

			</table>
		)
	}
}

export default HighScoreTable
