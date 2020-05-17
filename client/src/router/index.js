import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

import Tpi_verifyPlayerSession from '../views/Commands/Tpi_verifyPlayerSession.vue'

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
		component: Tpi_verifyPlayerSession,
	},
]

const router = new VueRouter({
	routes,
})

export default router
