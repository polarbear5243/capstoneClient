S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 5706
Date: 2017-04-09 00:30:13+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5706, uid 5000)

Register Information
r0   = 0x00000008, r1   = 0xbeb02140
r2   = 0xbeb02138, r3   = 0xbeb02140
r4   = 0xb27a7f05, r5   = 0xb760ff60
r6   = 0xb7a01ec8, r7   = 0xbeb02150
r8   = 0x800ee9b5, r9   = 0xb5ea7708
r10  = 0xb7706ee0, fp   = 0x00000000
ip   = 0x00000001, sp   = 0xbeb020f0
lr   = 0xb279cef1, pc   = 0xb279cef0
cpsr = 0x000f0030

Memory Information
MemTotal:   987012 KB
MemFree:    145356 KB
Buffers:     42336 KB
Cached:     334876 KB
VmPeak:     141528 KB
VmSize:     140216 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35984 KB
VmRSS:       35052 KB
VmData:      52144 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35796 KB
VmPTE:         106 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5706 TID = 5706
5706 5708 5968 5969 5977 

Maps Information
af12e000 af92d000 rw-p [stack:5977]
b0f21000 b0f32000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f42000 b0f47000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1349000 b1351000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1363000 b1b62000 rw-p [stack:5969]
b1b62000 b1b63000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b73000 b1b87000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b9b000 b1b9c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bac000 b1baf000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bc0000 b1bc1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bd1000 b1bd3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1be3000 b1be5000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bf5000 b1c05000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c15000 b1c21000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c33000 b2432000 rw-p [stack:5968]
b2763000 b276a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b277d000 b2783000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2793000 b27b3000 r-xp /opt/usr/apps/org.example.client/bin/client
b290b000 b29ee000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a25000 b2a4d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a5f000 b325e000 rw-p [stack:5708]
b325e000 b3260000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3270000 b327a000 r-xp /lib/libnss_files-2.20-2014.11.so
b328b000 b3294000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32a5000 b32b6000 r-xp /lib/libnsl-2.20-2014.11.so
b32c9000 b32cf000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32e0000 b32e1000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3309000 b3310000 r-xp /usr/lib/libminizip.so.1.0.0
b3320000 b3325000 r-xp /usr/lib/libstorage.so.0.1
b3335000 b3394000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33aa000 b33be000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33ce000 b3412000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3422000 b342a000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b343a000 b346a000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b347d000 b3536000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b354a000 b359d000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35ae000 b35c9000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35d9000 b369a000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36ad000 b36bd000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36cd000 b36da000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36eb000 b36f2000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3702000 b3743000 r-xp /usr/lib/libmdm.so.1.2.12
b3753000 b375b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b376a000 b377a000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b379b000 b37fb000 r-xp /usr/lib/libasound.so.2.0.0
b380d000 b3810000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3820000 b3823000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3833000 b3838000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3848000 b3849000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3859000 b3864000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3878000 b387f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b388f000 b3895000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38a5000 b38aa000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38ba000 b38d5000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38e5000 b38ec000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38fc000 b38ff000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3910000 b393e000 r-xp /usr/lib/libidn.so.11.5.44
b394e000 b3964000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3975000 b397f000 r-xp /usr/lib/libcares.so.2.1.0
b398f000 b3999000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39a9000 b39ab000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39bb000 b39bc000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39cc000 b39d0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39e1000 b3a09000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a1a000 b3a43000 r-xp /usr/lib/libturbojpeg.so
b3a63000 b3a69000 r-xp /usr/lib/libgif.so.4.1.6
b3a79000 b3abf000 r-xp /usr/lib/libcurl.so.4.3.0
b3ad0000 b3af1000 r-xp /usr/lib/libexif.so.12.3.3
b3b0c000 b3b21000 r-xp /usr/lib/libtts.so
b3b32000 b3b3a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b4a000 b3c10000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c30000 b3d28000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d47000 b3e15000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e2c000 b3e2e000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e3e000 b3e44000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e54000 b3e77000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e88000 b3e8a000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e9a000 b3e9c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ead000 b3eb2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ec9000 b3ecb000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3edb000 b3ee2000 r-xp /usr/lib/libsensord-share.so
b3ef2000 b3f0a000 r-xp /usr/lib/libsensor.so.1.1.0
b3f1b000 b3f1e000 r-xp /usr/lib/libXv.so.1.0.0
b3f2e000 b3f33000 r-xp /usr/lib/libutilX.so.1.1.0
b3f43000 b3f48000 r-xp /usr/lib/libappcore-common.so.1.1
b3f58000 b3f5f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f72000 b3f76000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f87000 b4065000 r-xp /usr/lib/libCOREGL.so.4.0
b4085000 b4088000 r-xp /usr/lib/libuuid.so.1.3.0
b4098000 b40af000 r-xp /usr/lib/libblkid.so.1.1.0
b40c0000 b40c2000 r-xp /usr/lib/libXau.so.6.0.0
b40d2000 b4119000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b412b000 b4131000 r-xp /usr/lib/libjson-c.so.2.0.1
b4142000 b4146000 r-xp /usr/lib/libogg.so.0.7.1
b4156000 b4178000 r-xp /usr/lib/libvorbis.so.0.4.3
b4188000 b426c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4288000 b428b000 r-xp /usr/lib/libEGL.so.1.4
b429c000 b42a2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42b2000 b42b4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42c4000 b42d1000 r-xp /usr/lib/libGLESv2.so.2.0
b42e2000 b4344000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4359000 b4371000 r-xp /usr/lib/libmount.so.1.1.0
b4383000 b4397000 r-xp /usr/lib/libxcb.so.1.1.0
b43a7000 b43ae000 r-xp /lib/libcrypt-2.20-2014.11.so
b43e6000 b43e8000 r-xp /usr/lib/libiri.so
b43f8000 b4403000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4414000 b444a000 r-xp /usr/lib/libpulse.so.0.16.2
b445b000 b449e000 r-xp /usr/lib/libsndfile.so.1.0.25
b44b3000 b44c8000 r-xp /lib/libexpat.so.1.5.2
b44da000 b4598000 r-xp /usr/lib/libcairo.so.2.11200.14
b45ac000 b45b4000 r-xp /usr/lib/libdrm.so.2.4.0
b45c4000 b45c7000 r-xp /usr/lib/libdri2.so.0.0.0
b45d7000 b4625000 r-xp /usr/lib/libssl.so.1.0.0
b463a000 b4646000 r-xp /usr/lib/libeeze.so.1.13.0
b4657000 b4660000 r-xp /usr/lib/libethumb.so.1.13.0
b4670000 b4673000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4683000 b483a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5625000 b562e000 r-xp /usr/lib/libXi.so.6.1.0
b563e000 b5640000 r-xp /usr/lib/libXgesture.so.7.0.0
b5650000 b5654000 r-xp /usr/lib/libXtst.so.6.1.0
b5664000 b566a000 r-xp /usr/lib/libXrender.so.1.3.0
b567a000 b5680000 r-xp /usr/lib/libXrandr.so.2.2.0
b5690000 b5692000 r-xp /usr/lib/libXinerama.so.1.0.0
b56a3000 b56a6000 r-xp /usr/lib/libXfixes.so.3.1.0
b56b6000 b56c1000 r-xp /usr/lib/libXext.so.6.4.0
b56d1000 b56d3000 r-xp /usr/lib/libXdamage.so.1.1.0
b56e3000 b56e5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56f5000 b57d7000 r-xp /usr/lib/libX11.so.6.3.0
b57eb000 b57f2000 r-xp /usr/lib/libXcursor.so.1.0.2
b5802000 b581a000 r-xp /usr/lib/libudev.so.1.6.0
b581c000 b581f000 r-xp /lib/libattr.so.1.1.0
b582f000 b584f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5850000 b5855000 r-xp /usr/lib/libffi.so.6.0.2
b5866000 b587e000 r-xp /lib/libz.so.1.2.8
b588e000 b5890000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58a0000 b5975000 r-xp /usr/lib/libxml2.so.2.9.2
b598a000 b5a25000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a41000 b5a44000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a54000 b5a6d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a7e000 b5a8f000 r-xp /lib/libresolv-2.20-2014.11.so
b5aa3000 b5b1d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b32000 b5b34000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b44000 b5b4b000 r-xp /usr/lib/libembryo.so.1.13.0
b5b5b000 b5b65000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b76000 b5b8e000 r-xp /usr/lib/libpng12.so.0.50.0
b5b9f000 b5bc2000 r-xp /usr/lib/libjpeg.so.8.0.2
b5be3000 b5bf7000 r-xp /usr/lib/libector.so.1.13.0
b5c08000 b5c20000 r-xp /usr/lib/liblua-5.1.so
b5c31000 b5c88000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c9c000 b5cc4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cd5000 b5ce8000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cf9000 b5d33000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d44000 b5d52000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d62000 b5d6a000 r-xp /usr/lib/libtbm.so.1.0.0
b5d7a000 b5d87000 r-xp /usr/lib/libeio.so.1.13.0
b5d97000 b5d99000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da9000 b5dae000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dbe000 b5dd5000 r-xp /usr/lib/libefreet.so.1.13.0
b5de7000 b5e07000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e17000 b5e37000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e39000 b5e3f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e4f000 b5e60000 r-xp /usr/lib/libemotion.so.1.13.0
b5e71000 b5e78000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e88000 b5e97000 r-xp /usr/lib/libeo.so.1.13.0
b5ea8000 b5eba000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ecb000 b5ed0000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ee0000 b5ef9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f09000 b5f26000 r-xp /usr/lib/libeet.so.1.13.0
b5f3f000 b5f87000 r-xp /usr/lib/libeina.so.1.13.0
b5f98000 b5fa8000 r-xp /usr/lib/libefl.so.1.13.0
b5fb9000 b609e000 r-xp /usr/lib/libicuuc.so.51.1
b60bb000 b61fb000 r-xp /usr/lib/libicui18n.so.51.1
b6212000 b624a000 r-xp /usr/lib/libecore_x.so.1.13.0
b625c000 b625f000 r-xp /lib/libcap.so.2.21
b626f000 b6298000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a9000 b62b0000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62c2000 b62f9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b630a000 b63f5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6408000 b6481000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6493000 b6498000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a8000 b64b2000 r-xp /usr/lib/libvconf.so.0.2.45
b64c2000 b64c4000 r-xp /usr/lib/libvasum.so.0.3.1
b64d4000 b64d6000 r-xp /usr/lib/libttrace.so.1.1
b64e6000 b64e9000 r-xp /usr/lib/libiniparser.so.0
b64f9000 b651f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b652f000 b6534000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6545000 b655c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b656d000 b65d8000 r-xp /lib/libm-2.20-2014.11.so
b65e9000 b65ef000 r-xp /lib/librt-2.20-2014.11.so
b6600000 b660d000 r-xp /usr/lib/libunwind.so.8.0.1
b6643000 b6767000 r-xp /lib/libc-2.20-2014.11.so
b677c000 b6795000 r-xp /lib/libgcc_s-4.9.so.1
b67a5000 b6887000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6898000 b68c2000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68d3000 b690f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6911000 b6994000 r-xp /usr/lib/libedje.so.1.13.0
b69a7000 b69c5000 r-xp /usr/lib/libecore.so.1.13.0
b69e5000 b6b6c000 r-xp /usr/lib/libevas.so.1.13.0
b6ba1000 b6bb5000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc9000 b6dfd000 r-xp /usr/lib/libelementary.so.1.13.0
b6e2c000 b6e30000 r-xp /usr/lib/libsmack.so.1.0.0
b6e40000 b6e47000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e57000 b6e59000 r-xp /usr/lib/libdlog.so.0.0.0
b6e69000 b6e6c000 r-xp /usr/lib/libbundle.so.0.1.22
b6e7c000 b6e7e000 r-xp /lib/libdl-2.20-2014.11.so
b6e8f000 b6ea7000 r-xp /usr/lib/libaul.so.0.1.0
b6ebb000 b6ec0000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ed1000 b6ede000 r-xp /usr/lib/liblptcp.so
b6ef0000 b6ef4000 r-xp /usr/lib/libsys-assert.so
b6f05000 b6f25000 r-xp /lib/ld-2.20-2014.11.so
b6f36000 b6f3b000 r-xp /usr/bin/launchpad-loader
b7293000 b7c56000 rw-p [heap]
beae2000 beb03000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5706)
Call Stack Count: 24
 0: _ZN16FoodMainFoodList14deleteFoodItemEPv + 0x4b (0xb279cef0) [/opt/usr/apps/org.example.client/bin/client] + 0x9ef0
 1: _ZThn16_N16FoodMainFoodList14deleteFoodItemEPv + 0x1a (0xb279d007) [/opt/usr/apps/org.example.client/bin/client] + 0xa007
 2:  + 0x0 (0xb279e6e7) [/opt/usr/apps/org.example.client/bin/client] + 0xb6e7
 3: _ZN6Button14callback_clickEPvP10_Eo_OpaqueS0_ + 0x24 (0xb27a7f29) [/opt/usr/apps/org.example.client/bin/client] + 0x14f29
 4: (0xb6a4b7ed) [/usr/lib/libevas.so.1] + 0x667ed
 5: (0xb5e93219) [/usr/lib/libeo.so.1] + 0xb219
 6: eo_event_callback_call + 0x68 (0xb5e91fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 7: evas_object_smart_callback_call + 0x38 (0xb6a4cedd) [/usr/lib/libevas.so.1] + 0x67edd
 8: (0xb6968167) [/usr/lib/libedje.so.1] + 0x57167
 9: (0xb696cd87) [/usr/lib/libedje.so.1] + 0x5bd87
10: (0xb6968b21) [/usr/lib/libedje.so.1] + 0x57b21
11: (0xb6968ef1) [/usr/lib/libedje.so.1] + 0x57ef1
12: (0xb6969045) [/usr/lib/libedje.so.1] + 0x58045
13: (0xb69b6d11) [/usr/lib/libecore.so.1] + 0xfd11
14: (0xb69b2c4b) [/usr/lib/libecore.so.1] + 0xbc4b
15: (0xb69b8a5d) [/usr/lib/libecore.so.1] + 0x11a5d
16: ecore_main_loop_begin + 0x3e (0xb69b8c83) [/usr/lib/libecore.so.1] + 0x11c83
17: appcore_efl_main + 0x20c (0xb6ebe2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
18: ui_app_main + 0xc0 (0xb3f74909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
19: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27a6b6f) [/opt/usr/apps/org.example.client/bin/client] + 0x13b6f
20: main + 0x40 (0xb27975f1) [/opt/usr/apps/org.example.client/bin/client] + 0x45f1
21: (0xb6f37bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
22: __libc_start_main + 0x114 (0xb66594bc) [/lib/libc.so.6] + 0x164bc
23: (0xb6f37eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
.400+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:29:00.400+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:29
04-09 00:29:00.400+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:29"
04-09 00:29:00.400+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:29"
04-09 00:29:00.400+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:29:00.400+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145962592 Time: <font_size=31> </font_size> <font_size=31> 오전 12:29</font_size></font>"
04-09 00:29:14.984+0900 E/PKGMGR_SERVER( 5754): pkgmgr-server.c: main(2414) > package manager server start
04-09 00:29:15.034+0900 E/PKGMGR  ( 5752): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-09 00:29:15.074+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-09 00:29:15.074+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5309
04-09 00:29:15.074+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
04-09 00:29:15.074+0900 W/AUL     ( 5757): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3248)
04-09 00:29:15.074+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:29:15.074+0900 E/AUL_AMD (  607): amd_request.c: __app_process_by_pid(272) > pid(3248) is dead. cmd(5) is canceled
04-09 00:29:15.074+0900 W/AUL     ( 5757): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-09 00:29:15.074+0900 E/PKGMGR_SERVER( 5757): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-09 00:29:15.074+0900 E/PKGMGR_SERVER( 5757): [0;m
04-09 00:29:15.074+0900 W/AUL     ( 5757): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3576)
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:29:15.084+0900 E/AUL_AMD (  607): amd_request.c: __app_process_by_pid(272) > pid(3576) is dead. cmd(5) is canceled
04-09 00:29:15.084+0900 W/AUL     ( 5757): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-09 00:29:15.084+0900 E/PKGMGR_SERVER( 5757): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-09 00:29:15.084+0900 E/PKGMGR_SERVER( 5757): [0;m
04-09 00:29:15.084+0900 W/AUL     ( 5757): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3853)
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:29:15.084+0900 E/AUL_AMD (  607): amd_request.c: __app_process_by_pid(272) > pid(3853) is dead. cmd(5) is canceled
04-09 00:29:15.084+0900 W/AUL     ( 5757): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-09 00:29:15.084+0900 E/PKGMGR_SERVER( 5757): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-09 00:29:15.084+0900 E/PKGMGR_SERVER( 5757): [0;m
04-09 00:29:15.084+0900 W/AUL     ( 5757): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5309)
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:29:15.084+0900 I/APP_CORE( 5309): appcore-efl.c: __do_app(514) > [APP 5309] Event: TERMINATE State: RUNNING
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(5309), cmd(4)
04-09 00:29:15.084+0900 W/AUL     ( 5757): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5309
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-09 00:29:15.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-09 00:29:15.094+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 5309): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 10
04-09 00:29:15.094+0900 E/APP_CORE( 5309): appcore-efl.c: _capture_and_make_file(1619) > win[6400002] widget[720] height[1280]
04-09 00:29:15.094+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
04-09 00:29:15.094+0900 E/APP_CORE( 5309): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-09 00:29:15.104+0900 I/CAPI_APPFW_APPLICATION( 5309): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:29:15.104+0900 I/CAPI_APPFW_APPLICATION( 5309): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-09 00:29:15.104+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:29:15.104+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:29:15.104+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:29:15.104+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:29:15.104+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:29:15.104+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:29:15.134+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:29:15.174+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:29:15.174+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:29:15.174+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:29:15.174+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:29:15.184+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-09 00:29:15.184+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-09 00:29:15.204+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:29:15.214+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:29:15.214+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:29:15.224+0900 E/PKGMGR_SERVER( 5754): pkgmgr-server.c: sighandler(417) > child NORMAL exit [5757]
04-09 00:29:15.234+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:29:15.234+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:29:15.234+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:29:15.234+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:29:15.244+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:29:15.244+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:29:15.244+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:29:15.274+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:29:15.314+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb8555a00]
04-09 00:29:15.314+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:29:15.314+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb8555a00
04-09 00:29:15.314+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:29:15.324+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:29:15.324+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:29:15.324+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:29:15.324+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:29:15.464+0900 E/VCONF   ( 5309): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
04-09 00:29:15.464+0900 E/VCONF   ( 5309): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
04-09 00:29:15.514+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5309 pgid = 5309
04-09 00:29:15.514+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(5309)
04-09 00:29:15.564+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:29:15.564+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:29:15.564+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:29:15.564+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[5309] terminate event is forwarded
04-09 00:29:15.564+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:29:15.564+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 5309, ]
04-09 00:29:15.564+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:29:15.564+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:29:15.564+0900 I/Tizen::App( 1246): (512) > Not registered pid(5309)
04-09 00:29:15.564+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:29:15.564+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:29:15.564+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 5309
04-09 00:29:15.564+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5309
04-09 00:29:15.574+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.502
04-09 00:29:15.584+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:29:15.584+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 5309.
04-09 00:29:16.816+0900 E/PKGMGR_SERVER( 5754): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-09 00:29:16.816+0900 E/PKGMGR_SERVER( 5754): pkgmgr-server.c: main(2471) > package manager server terminated.
04-09 00:29:19.118+0900 E/PKGMGR  ( 5847): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-09 00:29:19.198+0900 E/PKGMGR_SERVER( 5849): pkgmgr-server.c: main(2414) > package manager server start
04-09 00:29:19.248+0900 E/PKGMGR_SERVER( 5849): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-09 00:29:19.248+0900 E/PKGMGR_SERVER( 5849): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-09 00:29:19.258+0900 E/PKGMGR  ( 5847): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[58470002]
04-09 00:29:19.408+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-09 00:29:19.408+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-09 00:29:19.418+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-09 00:29:19.428+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-09 00:29:19.428+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-09 00:29:19.428+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-09 00:29:19.588+0900 W/CERT_SVC_VCORE( 5852): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-09 00:29:19.678+0900 E/rpm-installer( 5852): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-09 00:29:19.678+0900 E/rpm-installer( 5852): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-09 00:29:19.739+0900 E/PKGMGR_PARSER( 5852): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-09 00:29:19.759+0900 I/PRIVACY-MANAGER-CLIENT( 5852): SocketClient.cpp: SocketClient(37) > Client created
04-09 00:29:19.759+0900 I/PRIVACY-MANAGER-CLIENT( 5852): SocketClient.cpp: connect(62) > Client connected
04-09 00:29:19.759+0900 I/PRIVACY-MANAGER-SERVER(  938): SocketService.cpp: mainloop(230) > Got incoming connection
04-09 00:29:19.759+0900 I/PRIVACY-MANAGER-CLIENT( 5852): SocketClient.cpp: disconnect(72) > Client disconnected
04-09 00:29:19.759+0900 E/PKGMGR_CERT( 5852): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-09 00:29:19.759+0900 E/PKGMGR_CERT( 5852): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-09 00:29:19.769+0900 E/PKGMGR_CERT( 5852): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-09 00:29:19.809+0900 E/rpm-installer( 5852): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-09 00:29:19.809+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-09 00:29:19.809+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-09 00:29:19.809+0900 E/ESD     (  919): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-09 00:29:19.819+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-09 00:29:19.819+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-09 00:29:19.829+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-09 00:29:20.079+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-09 00:29:20.079+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-09 00:29:21.530+0900 E/PKGMGR_SERVER( 5849): pkgmgr-server.c: sighandler(417) > child NORMAL exit [5852]
04-09 00:29:21.811+0900 E/PKGMGR_SERVER( 5849): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-09 00:29:21.811+0900 E/PKGMGR_SERVER( 5849): pkgmgr-server.c: main(2471) > package manager server terminated.
04-09 00:29:22.381+0900 E/PKGMGR  ( 5901): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-09 00:29:22.461+0900 E/PKGMGR_SERVER( 5903): pkgmgr-server.c: main(2414) > package manager server start
04-09 00:29:22.511+0900 E/PKGMGR_SERVER( 5903): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-09 00:29:22.521+0900 E/PKGMGR_INFO( 5903): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-09 00:29:22.531+0900 E/rpm-installer( 5903): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-09 00:29:22.531+0900 E/PKGMGR_SERVER( 5903): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-09 00:29:22.541+0900 E/PKGMGR  ( 5901): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[59010002]
04-09 00:29:22.661+0900 E/PKGMGR_INSTALLER( 5906): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-09 00:29:22.661+0900 E/rpm-installer( 5906): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-09 00:29:22.671+0900 E/rpm-installer( 5906): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-09 00:29:22.671+0900 E/rpm-installer( 5906): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-09 00:29:22.671+0900 E/rpm-installer( 5906): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-09 00:29:22.671+0900 E/rpm-installer( 5906): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-09 00:29:22.671+0900 E/rpm-installer( 5906): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-09 00:29:22.721+0900 W/CERT_SVC_VCORE( 5906): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-09 00:29:22.771+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-09 00:29:22.771+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-09 00:29:22.781+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-09 00:29:22.781+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-09 00:29:22.781+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-09 00:29:23.032+0900 E/rpm-installer( 5906): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-09 00:29:23.032+0900 E/rpm-installer( 5906): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-09 00:29:23.032+0900 E/rpm-installer( 5906): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-09 00:29:23.032+0900 E/rpm-installer( 5906): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-09 00:29:23.032+0900 E/rpm-installer( 5906): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-09 00:29:23.032+0900 E/rpm-installer( 5906): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-09 00:29:23.042+0900 E/PKGMGR_PARSER( 5906): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-09 00:29:23.042+0900 E/PKGMGR_PARSER( 5906): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-09 00:29:23.082+0900 I/PRIVACY-MANAGER-CLIENT( 5906): SocketClient.cpp: SocketClient(37) > Client created
04-09 00:29:23.292+0900 E/PKGMGR_PARSER( 5906): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-09 00:29:23.302+0900 E/PKGMGR_CERT( 5906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-09 00:29:23.312+0900 E/PKGMGR_CERT( 5906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-09 00:29:23.312+0900 E/PKGMGR_CERT( 5906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-09 00:29:23.312+0900 E/PKGMGR_CERT( 5906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-09 00:29:23.312+0900 E/PKGMGR_CERT( 5906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-09 00:29:23.312+0900 E/PKGMGR_CERT( 5906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-09 00:29:23.312+0900 E/PKGMGR_CERT( 5906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-09 00:29:23.312+0900 E/PKGMGR_CERT( 5906): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-09 00:29:23.322+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-09 00:29:23.322+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [60]
04-09 00:29:23.322+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-09 00:29:23.332+0900 E/rpm-installer( 5906): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-09 00:29:23.352+0900 E/rpm-installer( 5906): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-09 00:29:23.362+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-09 00:29:23.362+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [100]
04-09 00:29:23.362+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-09 00:29:24.813+0900 E/PKGMGR_SERVER( 5903): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-09 00:29:25.214+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-09 00:29:25.214+0900 I/Tizen::App( 1246): (78) > Installation is Completed. [Package = org.example.client]
04-09 00:29:25.214+0900 I/Tizen::App( 1246): (671) > Enter. package(org.example.client), installationResult(0)
04-09 00:29:25.214+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-09 00:29:25.214+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-09 00:29:25.214+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-09 00:29:25.224+0900 I/Tizen::App( 1246): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-09 00:29:25.234+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-09 00:29:25.234+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-09 00:29:25.234+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-09 00:29:25.234+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-09 00:29:25.234+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-09 00:29:25.234+0900 I/Tizen::App( 1246): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-09 00:29:25.254+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-09 00:29:25.254+0900 E/HOME_APPS(  868): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-09 00:29:25.254+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-09 00:29:25.254+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-09 00:29:25.264+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-09 00:29:25.274+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-09 00:29:25.274+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-09 00:29:25.274+0900 E/PKGMGR_INFO( 1246): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-09 00:29:25.274+0900 I/Tizen::App( 1246): (683) > Application count(1) in this package
04-09 00:29:25.274+0900 I/Tizen::App( 1246): (703) > Exit.
04-09 00:29:25.274+0900 I/Tizen::App( 1246): (840) > Enter.
04-09 00:29:25.274+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-09 00:29:25.284+0900 E/PKGMGR_SERVER( 5903): pkgmgr-server.c: sighandler(417) > child NORMAL exit [5906]
04-09 00:29:25.284+0900 E/util-view(  868): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-09 00:29:25.294+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-09 00:29:25.294+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-09 00:29:25.294+0900 I/Tizen::App( 1246): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-09 00:29:25.294+0900 I/Tizen::App( 1246): (131) > Enter
04-09 00:29:25.304+0900 I/Tizen::App( 1246): (137) > org.example.client does not have launch condition
04-09 00:29:25.304+0900 I/Tizen::App( 1246): (883) > Exit.
04-09 00:29:25.304+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-09 00:29:26.815+0900 E/PKGMGR_SERVER( 5903): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-09 00:29:26.815+0900 E/PKGMGR_SERVER( 5903): pkgmgr-server.c: main(2471) > package manager server terminated.
04-09 00:29:29.368+0900 W/AUL     ( 5961): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-09 00:29:29.368+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
04-09 00:29:29.378+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-09 00:29:29.378+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-09 00:29:29.378+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-09 00:29:29.378+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 5961
04-09 00:29:29.378+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-09 00:29:29.388+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:29:29.388+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:29:29.388+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:29:29.388+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:29:29.398+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:29:29.408+0900 I/abc     ( 5706): abc
04-09 00:29:29.408+0900 I/CAPI_APPFW_APPLICATION( 5706): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:29:29.408+0900 I/CAPI_APPFW_APPLICATION( 5706): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:29:29.438+0900 E/TBM     ( 5706): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:29:29.498+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 5706, appid: org.example.client
04-09 00:29:29.498+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:29:29.508+0900 W/AUL     ( 5961): launch.c: app_request_to_launchpad(425) > request cmd(0) result(5706)
04-09 00:29:29.688+0900 D/basicui ( 5706): successed to load edc file
04-09 00:29:29.728+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:29:29.728+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:29:29.738+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:29:29.738+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:29:29.748+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:29:29.748+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:29:29.778+0900 I/MY_LOG  ( 5706): change
04-09 00:29:29.828+0900 I/APP_CORE( 5706): appcore-efl.c: __do_app(514) > [APP 5706] Event: RESET State: CREATED
04-09 00:29:29.838+0900 I/CAPI_APPFW_APPLICATION( 5706): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:29:29.848+0900 E/EFL     ( 5706): edje<5706> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:29:29.848+0900 E/EFL     ( 5706): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:29:29.848+0900 E/EFL     ( 5706): edje<5706> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:29:29.848+0900 E/EFL     ( 5706): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:29:29.858+0900 E/EFL     ( 5706): edje<5706> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:29:29.858+0900 E/EFL     ( 5706): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:29:29.868+0900 W/APP_CORE( 5706): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-09 00:29:29.868+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:29:29.989+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:29:29.989+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:29:29.989+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:29:29.999+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:29:29.999+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:29:29.999+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:29:29.999+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(5706) status(3)
04-09 00:29:29.999+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:29:29.999+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:29:29.999+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(5706)
04-09 00:29:29.999+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 5706, appid: org.example.client, status: fg
04-09 00:29:30.009+0900 I/APP_CORE( 5706): appcore-efl.c: __do_app(514) > [APP 5706] Event: RESUME State: CREATED
04-09 00:29:30.009+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:29:30.009+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:29:30.009+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:29:30.019+0900 I/APP_CORE( 5706): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:29:30.019+0900 I/APP_CORE( 5706): appcore-efl.c: __do_app(625) > [APP 5706] Initial Launching, call the resume_cb
04-09 00:29:30.019+0900 I/CAPI_APPFW_APPLICATION( 5706): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:29:30.369+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(5706) status(0)
04-09 00:29:30.549+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:29:30.549+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 5706.
04-09 00:29:30.559+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.512
04-09 00:29:31.330+0900 I/UXT     ( 5974): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:29:33.112+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6510297
04-09 00:29:33.112+0900 I/MY_LOG  ( 5706): Button pressed
04-09 00:29:33.182+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6510375
04-09 00:29:33.192+0900 E/VCONF   ( 5706): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:29:33.192+0900 E/VCONF   ( 5706): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:29:33.192+0900 E/VCONF   ( 5706): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:29:33.192+0900 E/VCONF   ( 5706): vconf.c: vconf_get_bool(2729) > vconf_get_bool(5706) : db/ise/keysound error
04-09 00:29:33.192+0900 E/VCONF   ( 5706): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:29:33.192+0900 E/VCONF   ( 5706): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:29:33.242+0900 I/MY_LOG  ( 5706): Button unpressed
04-09 00:29:33.312+0900 D/basicui ( 5706): successed to load edc file
04-09 00:29:33.332+0900 I/MY_LOG  ( 5706): change
04-09 00:29:35.003+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:29:35.114+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6512307
04-09 00:29:35.204+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6512395
04-09 00:29:36.355+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6513542
04-09 00:29:37.035+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6514228
04-09 00:29:37.866+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6515062
04-09 00:29:37.956+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6515150
04-09 00:29:39.808+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6517006
04-09 00:29:39.908+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6517094
04-09 00:29:40.419+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6517612
04-09 00:29:40.419+0900 I/MY_LOG  ( 5706): Button pressed
04-09 00:29:40.499+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6517689
04-09 00:29:40.499+0900 I/MY_LOG  ( 5706): Button unpressed
04-09 00:29:40.519+0900 E/EFL     ( 5706): elementary<5706> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:29:42.210+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6519408
04-09 00:29:42.220+0900 I/MY_LOG  ( 5706): Button pressed
04-09 00:29:42.311+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6519507
04-09 00:29:42.321+0900 I/MY_LOG  ( 5706): Button unpressed
04-09 00:29:42.381+0900 D/basicui ( 5706): successed to load edc file
04-09 00:29:42.401+0900 I/MY_LOG  ( 5706): change
04-09 00:29:43.622+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6520803
04-09 00:29:44.202+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6521378
04-09 00:29:44.963+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6522152
04-09 00:29:45.053+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6522240
04-09 00:29:45.834+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6523025
04-09 00:29:45.914+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6523102
04-09 00:29:47.546+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6524735
04-09 00:29:47.546+0900 I/MY_LOG  ( 5706): Button pressed
04-09 00:29:47.626+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6524823
04-09 00:29:47.626+0900 I/MY_LOG  ( 5706): Button unpressed
04-09 00:29:47.646+0900 E/EFL     ( 5706): elementary<5706> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:30:00.398+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:30:00.408+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:30
04-09 00:30:00.408+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:30"
04-09 00:30:00.408+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:30"
04-09 00:30:00.408+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:30:00.408+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145924117 Time: <font_size=31> </font_size> <font_size=31> 오전 12:30</font_size></font>"
04-09 00:30:04.993+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:30:04.993+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:30:11.619+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6548808
04-09 00:30:11.669+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6548863
04-09 00:30:11.719+0900 D/basicui ( 5706): successed to load edc file
04-09 00:30:11.739+0900 I/MY_LOG  ( 5706): change
04-09 00:30:11.749+0900 I/MY_LOG  ( 5706): change
04-09 00:30:11.769+0900 I/MY_LOG  ( 5706): change
04-09 00:30:12.670+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:30:12.670+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:30:13.241+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=6550434
04-09 00:30:13.241+0900 I/MY_LOG  ( 5706): Button pressed
04-09 00:30:13.301+0900 E/EFL     ( 5706): ecore_x<5706> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=6550489
04-09 00:30:13.311+0900 I/MY_LOG  ( 5706): Button unpressed
04-09 00:30:13.591+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5706 pgid = 5706
04-09 00:30:13.591+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(5706)
04-09 00:30:13.591+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:30:13.621+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:30:13.621+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:30:13.621+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:30:13.621+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:30:13.621+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:30:13.661+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:30:13.661+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:30:13.661+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:30:13.661+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 5706
04-09 00:30:13.661+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[5706] terminate event is forwarded
04-09 00:30:13.661+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:30:13.661+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 5706, ]
04-09 00:30:13.661+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:30:13.661+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:30:13.661+0900 I/Tizen::App( 1246): (512) > Not registered pid(5706)
04-09 00:30:13.661+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:30:13.661+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:30:13.661+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5706
04-09 00:30:13.661+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 5706
04-09 00:30:13.671+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.516
04-09 00:30:13.671+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:30:13.671+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:30:13.671+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:30:13.671+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:30:13.671+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:30:13.671+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:30:13.671+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 5706.
04-09 00:30:13.701+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:30:13.731+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:30:13.731+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:30:13.741+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:30:13.751+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:30:13.761+0900 W/CRASH_MANAGER( 5983): worker.c: worker_job(1199) > 1105706636c69149166541
