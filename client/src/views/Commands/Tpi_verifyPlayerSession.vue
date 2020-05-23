<template>
	<v-container fluid>
		<app-tab @changedTab="selectedTab"></app-tab>
		<keep-alive>
			<component :is="selectedComponent"></component>
		</keep-alive>
	</v-container>
</template>

<script>
	import AppTab from '../../components/MethodContent/Tab.vue'

	export default {
		components: {
			AppTab,
			'app-request': () => import('../../components/MethodContent/Request.vue'), // overkill
			'app-detail': () => import('../../components/MethodContent/Detail.vue'), // overkill
		},
		data: () => ({
			selectedComponent: 'app-detail',
		}),
		methods: {
			selectedTab(tab) {
				if (tab === 'request') this.selectedComponent = 'app-request'
				else this.selectedComponent = 'app-detail'
			},
		},
	}
</script>
