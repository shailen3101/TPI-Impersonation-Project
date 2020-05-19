import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import { commands } from '../util/data'

Vue.use(VueRouter)

function filterCommandByUrl(route) {
	const urlCommand = route.params.command
	return { urlCommandObject: commands.find((c) => c.name === urlCommand) }
}

const routes = [
	{
		path: '/',
		name: 'Home',
		component: Home,
	},
	{
		path: '/command/:command',
		name: 'Command',
		component: () =>
			import(
				/* webpackChunkName: "group-command" */ '../views/Commands/Tpi_verifyPlayerSession.vue'
			),
		props: filterCommandByUrl,
	},
]

const router = new VueRouter({
	routes,
})

export default router
