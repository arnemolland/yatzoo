import React, {Component} from 'react';
import {Route} from 'react-router';
import {Layout} from './components/Layout';
import Home from './views/Home';
import HighScores from './views/HighScores';
import Test from './views/Test';

export default class App extends Component {
	static displayName = App.name;

	render() {
		return (
			<Layout>
				<Route exact path='/' component={Home} />
				<Route exact path='/highscores' component={HighScores} />
				<Route exact path='/test' component={Test} />
			</Layout>
		);
	}
}
