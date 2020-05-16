<template>
	<v-app>
		<app-header></app-header>
		<router-view></router-view>
	</v-app>
</template>

<script>
	import AppHeader from './components/Shared/Header.vue'

	export default {
		name: 'App',
		components: {
			AppHeader,
		},
		data: () => ({
			//
		}),
	}
</script>
