<template>
	<v-container fluid>
		<app-tab @changedTab="selectedTab"></app-tab>
		<component :is="selectedComponent"></component>
	</v-container>
</template>

<script>
	import AppTab from '../../components/MethodContent/Tab.vue'

	export default {
		data: () => ({
			selectedComponent: 'app-request',
		}),
		components: {
			AppTab,
			'app-request': () => import('../../components/MethodContent/Request.vue'), // overkill
		},
		methods: {
			selectedTab(tab) {
				if (tab === 'request') this.selectedComponent = 'app-request'
				else this.selectedComponent = 'app-details'
			},
		},
	}
</script>
