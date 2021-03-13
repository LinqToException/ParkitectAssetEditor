namespace ParkitectAssetEditor.UI.AssetHandlers
{
    public interface IAssetTypeHandler
    {
        /// <summary>
        /// Called by <see cref="AssetEditorWindow.DrawAssetDetailSection"/>
        /// and used to draw the detail asset settings.
        /// </summary>
        /// <param name="selectedAsset"></param>
        void DrawDetailsSection(Asset selectedAsset);
    }
}
