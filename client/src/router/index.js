import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

const routes = [
	{
		path: '/',
		name: 'Home',
		component: Home,
	},
	{
		path: '/command/Tpi_verifyPlayerSession',
		name: 'Tpi_verifyPlayerSession',
		component: () =>
			import(
				/* webpackChunkName: "group-command" */ '../views/Commands/Tpi_verifyPlayerSession.vue'
			),
	},
]

const router = new VueRouter({
	routes,
})

export default router
