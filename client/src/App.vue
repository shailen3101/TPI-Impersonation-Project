<template>
	<v-app>
		<app-header></app-header>
		<app-content></app-content>
	</v-app>
</template>

<script>
	import AppHeader from './components/Shared/Header.vue'
	import AppContent from './components/Shared/Content.vue'

	export default {
		name: 'App',
		components: {
			AppHeader,
			AppContent,
		},
		data: () => ({
			//
		}),
	}
</script>
