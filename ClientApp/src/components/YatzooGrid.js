import React, {Component} from 'react'

import YatzooController from './YatzooController'
import YatzooGridRow from './YatzooGridRow'

import './YatzooGrid.css'

class YatzooGrid extends Component {

	render() {
		return (
			<div>

				{/* Yatzoo controls */}
				<YatzooController></YatzooController>

				{/* Yatzoo table */}
				<table>
					<tr>
						<th></th>
						<th>Player 1</th>
						<th>Player 2</th>
						<th>Player 3</th>
						<th>Player 4</th>
						<th>Player 5</th>
					</tr>

					{/* Animal rows */}
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>

					{/* Special rows */}
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>

					{/* Final score rows */}
					<YatzooGridRow image={{}} rowdata={{}}></YatzooGridRow>

				</table>
			</div>
		)
	}
}

export default YatzooGrid
