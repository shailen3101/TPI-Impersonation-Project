import Vue from 'vue'
import Vuex from 'vuex'

import CommandModule from './modules/command'

Vue.use(Vuex)

export default new Vuex.Store({
	modules: {
		CommandModule,
	},
})
