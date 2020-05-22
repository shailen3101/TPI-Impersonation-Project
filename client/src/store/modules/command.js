import { commands } from '../../util/data.js'

const state = {
	commands: commands,
}

const getters = {
	getCommand: (state) => (command) => {
		console.log(command)
		return state.commands.find((c) => c.name === command)
	},
}

const mutations = {
	updateParameters: (state, playload) => {
		state.comands.find((c) => {
			if (c.name === playload.name) {
				c.parameters = playload.parameterss
			}
		})
	},
	updateResponse: (state, playload) => {
		console.log(playload)
	},
}

const actions = {
	asyncSendRequet: () => {
		// Make the API request
		// 1: Extract the request data
		// 2: Post the request to the API
		// 3: Update the response
	},
}

export default {
	state,
	getters,
	mutations,
	actions,
}
